using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using TimeTrackerITU.Models;

namespace TimeTrackerITU.Converters
{
    public class EntriesToOneDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<EntryModel> entriesList = (ObservableCollection<EntryModel>)value;

            DateTime Date = new DateTime();

            foreach (var entry in entriesList)
            {
                Date = entry.StartTime;
            }

            return String.Format("{0:dd/MM/yyyy}", Date);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}