namespace AmznSellingPartner.BuildTools.ViewModels
{
    using System;
    using System.Windows.Input;

    public class Command(Action executeable) : ICommand
    {
        private readonly Action executeable = executeable;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object _)
            => this.executeable is not null;

        public void Execute(object _)
            => App.Invoke(this.executeable);
    }
}
