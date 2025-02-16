namespace AmznSellingPartner.BuildTools.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ViewModel<T> : INotifyPropertyChanged where T : ViewModel<T>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetValue(Action<T> memberValueSetterExpression, [CallerMemberName] string member = "")
        {
            if (this is T vm)
            {
                App.Invoke(() => memberValueSetterExpression(vm));

                if (this.PropertyChanged is not null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(member));
                }
            }
        }
    }
}
