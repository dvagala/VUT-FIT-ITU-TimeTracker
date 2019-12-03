using System.Windows;
using System.Windows.Media;
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

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}