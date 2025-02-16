namespace AmznSellingPartner.BuildTools.ViewModels.Pages
{
    using AmznSellingPartner.BuildTools.Models;

    using System.Collections.ObjectModel;
    using System.IO;

    public class GitPageViewModel : ViewModel<GitPageViewModel>
    {
        private readonly CmdManager cmd;

        public GitPageViewModel()
        {
            this.cmd = new CmdManager();
            this.cmd.CmdResponse += this.OnCmdResponse;
            this.GitInfo = [];

            this.InitializeViewModel();
        }

        private bool isCloneEnabled;
        public bool IsCloneEnabled
        {
            get => this.isCloneEnabled;
            set => this.SetValue(x => x.isCloneEnabled = value);
        }

        private bool isInitEnabled;
        public bool IsInitEnabled
        {
            get => this.isInitEnabled;
            set => this.SetValue(x => x.isInitEnabled = value);
        }

        public ObservableCollection<CmdResponse> GitInfo { get; }

        private void InitializeViewModel()
        {
            var directory = Path.Combine(AppSettings.CurrentDirectory, AppSettings.SpModelsDirName);

            Directory.CreateDirectory(directory);

            this.cmd.Run(new CmdRequest
            {
                Command = "git status",
                Directory = directory,
            });
        }

        private void OnCmdResponse(CmdResponse response)
            => App.Invoke(() => this.GitInfo.Add(response));
    }
}
