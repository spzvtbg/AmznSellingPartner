namespace AmznSellingPartner.BuildTools
{
    using System;
    using System.Windows;

    public partial class App : Application
    {
        public static readonly Action<Action> Invoke = App.Current.Dispatcher.Invoke;
    }
}
