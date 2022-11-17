using Prism.Services.Dialogs;

using System.Windows;
using System.Windows.Input;

namespace WPF_PrismCustomDialogStyle_Demo.Components
{
    /// <summary>
    /// DialogWindowView.xaml 的交互逻辑
    /// </summary>
    public partial class DialogWindowView : Window,IDialogWindow
    {
        public DialogWindowView()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Close, CloseEvent));
        }

        public IDialogResult Result { get; set; }

        private void CloseEvent(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
