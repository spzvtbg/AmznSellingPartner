namespace AmznSellingPartner.BuildTools.Controls
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Navigation;

    public partial class MainMenu : Menu
    {
        public MainMenu() => this.InitializeComponent();

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            if (sender is not MenuItem menuItem)
            {
                MessageBox.Show($"{sender} is not of type {typeof(MenuItem)}");

                return;
            }

            if (menuItem.Parent is not MainMenu mainMenu)
            {
                MessageBox.Show($"{nameof(menuItem)}.{nameof(Parent)} is not of type {typeof(MainMenu)}");

                return;
            }

            if (mainMenu.Parent is not Grid grid)
            {
                MessageBox.Show($"{nameof(mainMenu)}.{nameof(Parent)} is not of type {typeof(Grid)}");

                return;
            }

            if (grid.Parent is not Page page)
            {
                MessageBox.Show($"{nameof(grid)}.{nameof(Parent)} is not of type {typeof(Page)}");

                return;
            }

            if (page.Parent is not NavigationWindow window)
            {
                MessageBox.Show($"{nameof(page)}.{nameof(Parent)} is not of type {typeof(NavigationWindow)}");

                return;
            }

            foreach (MenuItem item in mainMenu.Items)
            {
                item.IsEnabled = true;
            }

            menuItem.IsEnabled = false;

            window.Navigate(new Uri($"{menuItem.Tag}", UriKind.Relative));
        }
    }
}
