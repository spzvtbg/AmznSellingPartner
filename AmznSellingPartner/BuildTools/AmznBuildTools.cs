namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System;

    internal class AmznBuildTools
    {
        internal static void Build()
        {
            var stopwatch = Stopwatch.StartNew();
            var unhandled = new ConcurrentDictionary<string, ConcurrentDictionary<string, HashSet<JToken>>>();

            void AmznModel_UnhandledData(string type, string field, JToken value)
              => unhandled.GetOrAdd(type, [])
                          .GetOrAdd(field, [])
                          .Add(value);

            AmznModel.UnhandledData += AmznModel_UnhandledData;

            var slnDir = new DirectoryInfo(@"..\..\..\..\");
            var modelsDir = slnDir.CreateSubdirectory(@"selling-partner-api\models");
            var clientsCsproj = "AmznSellingPartner.Clients\\AmznSellingPartner.Clients.csproj";
            var clientsPath = Path.Combine(slnDir.FullName, "AmznSellingPartner.Clients.*/*.cs");
            var consoleColor = Console.ForegroundColor;
            var totalPropjects = 0;
            var totalFiles = 0;

            Cmd("git submodule update --progress --init --recursive --force --rebase --remote", slnDir.FullName);

            Console.WriteLine(new string('=', 100));

            foreach (var dir in modelsDir.GetDirectories())
            {
                var modelName = dir.Name.ToModelName();
                var modelNs = $"AmznSellingPartner.Clients.{modelName}";
                var modelDir = slnDir.CreateSubdirectory(modelNs);
                var modelCsproj = $"{modelNs}\\{modelNs}.csproj";

                if (!File.Exists(Path.Combine(modelDir.FullName, $"{modelNs}.csproj")))
                {
                    Cmd($"dotnet new classlib -o {modelNs} --force", slnDir.FullName);

                    File.WriteAllText(
                        path: Path.Combine(modelDir.FullName, $"{modelNs}.csproj"),
                        contents: @"<Project Sdk=""Microsoft.NET.Sdk"">
	<PropertyGroup>
		<TargetFramework>net9.0</TargetFramework>
		<ImplicitUsings>disable</ImplicitUsings>
		<Nullable>disable</Nullable>
	</PropertyGroup>
</Project>");

                    Cmd($"dotnet add {modelCsproj} reference {clientsCsproj}", slnDir.FullName);
                    Cmd($"dotnet sln add {modelCsproj}", slnDir.FullName);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Updateting: {modelCsproj}");
                    Console.ForegroundColor = consoleColor;
                }

                var filesDeleted = 0;
                var filesCreated = 0;

                foreach (var file in dir.EnumerateFiles("*.json"))
                {
                    var clientName = file.Name.ToClientName();
                    var clientNs = $"{modelNs}.{clientName}";
                    var clientDir = modelDir.CreateSubdirectory(clientName);
                    var jcontent = File.ReadAllText(file.FullName).Replace("$", string.Empty);
                    var amznModel = JsonConvert.DeserializeObject<AmznModel>(jcontent, AmznConverter.Settings);

                    foreach (var _file in modelDir.GetFiles("*.cs", SearchOption.AllDirectories))
                    {
                        _file.Delete();

                        filesDeleted++;
                    }

                    foreach (var (path, content) in amznModel.GetClassList(clientNs, clientDir.FullName))
                    {
                        File.WriteAllText(path, content);

                        filesCreated++;
                    }

                    totalPropjects++;
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Deleted: {filesDeleted} file{(filesDeleted == 1 ? '\0' : 's')}");
                Console.WriteLine($"Created: {filesCreated} file{(filesCreated == 1 ? '\0' : 's')}");
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(new string('=', 100));

                totalFiles += filesCreated;
            }

            AmznModel.UnhandledData -= AmznModel_UnhandledData;

            File.WriteAllText(@"..\..\..\unhandled.json", JsonConvert.SerializeObject(unhandled, Formatting.Indented));

            stopwatch.Stop();

            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"Total projects: {totalPropjects} project{(totalPropjects == 1 ? '\0' : 's')}");
            Console.WriteLine($"Total files: {totalFiles} file{(totalFiles == 1 ? '\0' : 's')}");
            Console.WriteLine($"Total time: {stopwatch.Elapsed}");
        }

        static void Cmd(string cmd, string workingDirectory)
        {
            var process = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = new ProcessStartInfo
                {
                    Arguments = $"/C {cmd}",
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    WorkingDirectory = workingDirectory
                },
            };

            void ErrorDataReceived(object _, DataReceivedEventArgs args)
            {
                if (!string.IsNullOrWhiteSpace(args.Data))
                {
                    var consoleColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(args.Data.Trim());
                    Console.ForegroundColor = consoleColor;
                }
            }

            void OutputDataReceived(object _, DataReceivedEventArgs args)
            {
                if (!string.IsNullOrWhiteSpace(args.Data))
                {
                    var consoleColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(args.Data.Trim());
                    Console.ForegroundColor = consoleColor;
                }
            }

            process.ErrorDataReceived += ErrorDataReceived;
            process.OutputDataReceived += OutputDataReceived;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.Close();

            process.OutputDataReceived -= OutputDataReceived;
            process.ErrorDataReceived -= ErrorDataReceived;
        }
    }
}
