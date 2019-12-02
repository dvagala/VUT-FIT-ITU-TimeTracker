using System.Windows;
using TimeTrackerITU.ViewModels;

namespace TimeTrackerITU.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel viewmodel = new MainWindowViewModel();

            DataContext = viewmodel;
        }
    }
}