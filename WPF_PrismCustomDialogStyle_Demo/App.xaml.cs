using WPF_PrismCustomDialogStyle_Demo.Views;
using Prism.Ioc;
using System.Windows;
using WPF_PrismCustomDialogStyle_Demo.ViewModels;
using Prism.Services.Dialogs;
using WPF_PrismCustomDialogStyle_Demo.Components;

namespace WPF_PrismCustomDialogStyle_Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDialogWindow, DialogWindowView>(nameof(DialogWindowView));
            containerRegistry.RegisterForNavigation<TestDialogView, TestDialogViewModel>();
        }
    }
}
