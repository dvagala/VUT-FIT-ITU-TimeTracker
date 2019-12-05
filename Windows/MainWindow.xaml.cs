using System;
using System.Windows;
using System.Windows.Input;
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

        private void employeeText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (employeeText.Text == "Employee number")
            {
                employeeText.Text = "";
                employeeText.Foreground = new SolidColorBrush(Colors.Black);
            }
            

        }
        private void passwordText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(passwordText.Text == "Enter password")
            {
                passwordText.Text = "";
                passwordText.Foreground = new SolidColorBrush(Colors.Black);
            }
            
        }
        
        private void sinceText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            sinceText.Text = "";
            sinceText.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void untilText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            untilText.Text = "";
            untilText.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void sinceText1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            sinceText1.Text = "";
            sinceText1.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void untilText1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            untilText1.Text = "";
            untilText1.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void sumText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            sumText.Text = "";
            sumText.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void sumText1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            sumText1.Text = "";
            sumText1.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void upArrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            timerAfterText.Text = (Int32.Parse(timerAfterText.Text) + 1).ToString();
        }
        private void downArrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(Int32.Parse(timerAfterText.Text) > 0)
            {
                timerAfterText.Text = (Int32.Parse(timerAfterText.Text) - 1).ToString();

            }
        }


    }

}