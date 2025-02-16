namespace AmznSellingPartner.BuildTools.Models
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class CmdManager
    {
        public event Action<CmdResponse> CmdResponse;

        public void Run(CmdRequest request)
        {
            Task.Factory.StartNew(() =>
            {
                var process = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        Arguments = $"/C {request.Command}",
                        CreateNoWindow = true,
                        FileName = "cmd.exe",
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        WorkingDirectory = request.Directory
                    },
                };

                process.ErrorDataReceived += this.ErrorDataReceived;
                process.OutputDataReceived += this.OutputDataReceived;

                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
                process.WaitForExit();
                process.Close();

                process.OutputDataReceived -= this.OutputDataReceived;
                process.ErrorDataReceived -= this.ErrorDataReceived;
            });
        }

        private void ErrorDataReceived(object _, DataReceivedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.Data))
            {
                this.CmdResponse?.Invoke(new CmdResponse
                {
                    Status = false,
                    Line = args.Data.Trim(),
                });
            }
        }

        private void OutputDataReceived(object _, DataReceivedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.Data))
            {
                this.CmdResponse?.Invoke(new CmdResponse
                {
                    Status = true,
                    Line = args.Data.Trim(),
                });
            }
        }
    }
}
