using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using TimeTrackerITU.Models;

namespace TimeTrackerITU.Converters
{
    public class EntriesToSumDurationCoverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<EntryModel> entriesList = (ObservableCollection<EntryModel>) value;

            TimeSpan sumEntriesDuration = new TimeSpan(0,0,0);


            foreach (var entry in entriesList)
            {
                sumEntriesDuration += entry.Duration;
            }
            return sumEntriesDuration.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}