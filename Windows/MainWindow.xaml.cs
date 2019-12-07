using System;
using System.Windows;
using System.Windows.Controls;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.Write("inner");
            e.Handled = true;
        }

        private void arrowControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock blockObject = (TextBlock)sender;
            switch (blockObject.Name)
            {
                case "timerUp":
                    timerAfterText.Text = (Int32.Parse(timerAfterText.Text) + 1).ToString();
                    break;
                case "timerDown":
                    if(Int32.Parse(timerAfterText.Text) > 0)
                    timerAfterText.Text = (Int32.Parse(timerAfterText.Text) - 1).ToString();
                    break;
                case "hourUp":
                    if (Int32.Parse(hourEdit.Text) >= 24)
                    {
                        hourEdit.Text = "1";
                    }
                    else
                    {
                        hourEdit.Text = (Int32.Parse(hourEdit.Text) + 1).ToString();
                    }
                    break;
                case "hourDown":
                    if (Int32.Parse(hourEdit.Text) <= 1)
                    {
                        hourEdit.Text = "24";
                    }
                    else
                    {
                        hourEdit.Text = (Int32.Parse(hourEdit.Text) - 1).ToString();
                    }
                    break;
                case "minutesUp":
                    if (Int32.Parse(minutesEdit.Text) >= 60)
                    {
                        minutesEdit.Text = "0";
                    }
                    else
                    {
                        minutesEdit.Text = (Int32.Parse(minutesEdit.Text) + 1).ToString();
                    }
                    break;
                case "minutesDown":
                    if (Int32.Parse(minutesEdit.Text) <= 0)
                    {
                        minutesEdit.Text = "59";
                    }
                    else
                    {
                        minutesEdit.Text = (Int32.Parse(minutesEdit.Text) - 1).ToString();
                    }
                    break;


            }

            
        }


    }

}