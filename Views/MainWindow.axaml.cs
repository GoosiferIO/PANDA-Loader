using Avalonia.Controls;
using PandaLdr.ViewModels;

namespace PandaLdr.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}