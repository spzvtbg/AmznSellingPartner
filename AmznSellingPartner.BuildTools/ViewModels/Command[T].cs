namespace AmznSellingPartner.BuildTools.ViewModels
{
    using System;
    using System.Windows.Input;

    public class Command<T>(Action<T> executeable) : ICommand
    {
        private readonly Action<T> executeable = executeable;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object _)
            => this.executeable is not null;

        public void Execute(object o)
            => App.Invoke(() => this.executeable(o is T t ? t : default));
    }
}
