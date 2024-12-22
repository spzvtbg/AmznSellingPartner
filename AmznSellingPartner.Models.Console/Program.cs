namespace AmznSellingPartner.Models.Console
{
    using AmznSellingPartner.Models.Console.CSharp;
    using AmznSellingPartner.Models.Console.Json;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;

    class Program
    {
        static Dictionary<string, Dictionary<string, HashSet<JToken>>> unhandled = [];

        static void Main()
        {
            JExtensions.NotImplemented += AddUnhandled;

            var swaggers = new List<JSwagger>();

            foreach (var file in Directory.GetFiles("./models", "*.json", SearchOption.AllDirectories))
            {
                var json = File.ReadAllText(file)?.Replace("$", string.Empty);
                var jswagger = JsonConvert.DeserializeObject<JSwagger>(json);

                foreach (var csNamespace in jswagger.ToCSNamespaces())
                {
                    BuildProject(csNamespace);
                }

                break;
            }

            JExtensions.NotImplemented -= AddUnhandled;

            var junhandled = JsonConvert.SerializeObject(unhandled, Formatting.Indented);
            File.WriteAllText("../../../unhandled.json", junhandled);
        }

        private static void AddUnhandled(string jtype, string jpath, JToken jtoken)
        {
            if (!unhandled.TryGetValue(jtype, out var unhandledTypes))
            {
                unhandled[jtype] = [];
                unhandledTypes = unhandled[jtype];
            }

            if (!unhandledTypes.TryGetValue(jpath, out var unhandledPaths))
            {
                unhandledTypes[jpath] = [];
                unhandledPaths = unhandledTypes[jpath]; 
            }

            unhandledPaths.Add(jtoken);
        }

        private static void BuildProject(CSNamespace csNamespace)
        {
            var directoryInfo = new DirectoryInfo(".")
                .Parent
                .Parent
                .Parent
                .Parent;
            var workingDirectory = directoryInfo.FullName;
            var sln = directoryInfo.Name;
            var csproj = csNamespace.Name;

            RunCmd($"dotnet new classlib -n {csproj} -o {csproj} --force", workingDirectory);
            RunCmd($"dotnet sln {sln}.sln add {csproj}/{csproj}.csproj", workingDirectory);

            workingDirectory = Path.Combine(workingDirectory, csproj);

            RunCmd($"del *.cs", workingDirectory);

            var tasks = new List<Task>();

            foreach (var csClass in csNamespace.Classes)
            {
                var cmd = $"dotnet new class -n {csClass.Name} --project {csproj}.csproj --force";

                tasks.Add(Task.Run(() => RunCmd(cmd, workingDirectory)));
            }

            Task.WaitAll(tasks);
            File.WriteAllText($"{workingDirectory}\\{csproj}.csproj", @"<Project Sdk=""Microsoft.NET.Sdk"">
	<PropertyGroup>
		<TargetFramework>net9.0</TargetFramework>
		<ImplicitUsings>disable</ImplicitUsings>
		<Nullable>disable</Nullable>
	</PropertyGroup>
</Project>");

            RunCmd($"dotnet build", workingDirectory);
        }

        private static void RunCmd(string arguments, string workingDirectory)
        {
            var process = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = new ProcessStartInfo
                {
                    Arguments = $"/C {arguments}",
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    WorkingDirectory = workingDirectory,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    FileName = "cmd.exe",
                }
            };

            void dataReceived(object sender, DataReceivedEventArgs args)
            {
                var data = args?.Data?.Trim();

                if (!string.IsNullOrWhiteSpace(data))
                {
                    Console.WriteLine(data);
                }
            }

            process.ErrorDataReceived += dataReceived;
            process.OutputDataReceived += dataReceived;
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.ErrorDataReceived -= dataReceived;
            process.OutputDataReceived -= dataReceived;
        }
    }
}
