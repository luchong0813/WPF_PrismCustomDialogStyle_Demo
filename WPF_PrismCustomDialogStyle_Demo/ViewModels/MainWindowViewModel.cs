using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Services.Dialogs;

using System;

using WPF_PrismCustomDialogStyle_Demo.Components;
using WPF_PrismCustomDialogStyle_Demo.Views;

namespace WPF_PrismCustomDialogStyle_Demo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "自定义Prism弹窗(Dialog)窗体样式";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private readonly IDialogService dialogService;

        public MainWindowViewModel(IContainerProvider provider)
        {
            dialogService = provider.Resolve<IDialogService>();

            OpenDialogCommand = new DelegateCommand(OpenDialog);
            CustomOpenDialogCommand = new DelegateCommand(CustomOpenDialog);
        }

        private void CustomOpenDialog()
        {
            DialogParameters dialogParameters = new DialogParameters()
            {
                {"Title",$"傲慢与偏见 {DateTime.Now:yyyy-MM-dd}" }
            };
            dialogService.Show(nameof(TestDialogView), dialogParameters, result =>
            {

            }, nameof(DialogWindowView));
        }

        private void OpenDialog()
        {
            DialogParameters dialogParameters = new DialogParameters()
            {
                {"Title",$"傲慢与偏见 {DateTime.Now:yyyy-MM-dd}" }
            };
            dialogService.Show(nameof(TestDialogView), dialogParameters, result =>
            {

            });
        }

        public DelegateCommand OpenDialogCommand { get; set; }
        public DelegateCommand CustomOpenDialogCommand { get; set; }
    }
}
