namespace AutomatedCar.Views
{
    using AutomatedCar.ViewModels;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class DashboardView : UserControl
    {
        public DashboardView()
        {
            this.InitializeComponent();         
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}