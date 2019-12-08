using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerITU.Models;

namespace TimeTrackerITU.Helpers
{
    public class SortedEntriesByDay : ObservableCollection<ObservableCollection<EntryModel>>
    {
        public SortedEntriesByDay()
        {
            ObservableCollection<EntryModel> dayEntries1= new ObservableCollection<EntryModel>();

            EntryModel entryModel = new EntryModel
            {
                Description = "Doing front end",
                Project = "ITU project",
                StartTime = new DateTime(2019, 9, 4, 16, 5, 7, 123),
                EndTime = new DateTime(2019, 9, 4, 18, 5, 7, 123),
                Duration = new TimeSpan(2, 14, 23),
                Color = "Green"
            };
            dayEntries1.Add(entryModel);


            entryModel = new EntryModel
            {
                Description = "Doing nothung",
                Project = "Secret",
                StartTime = new DateTime(2019, 9, 4, 10, 5, 7, 123),
                EndTime = new DateTime(2019, 9, 4, 13, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Orange"
            };
            dayEntries1.Add(entryModel);

            entryModel = new EntryModel
            {
                Description = "Doing backed",
                Project = "redhat satelite",
                StartTime = new DateTime(2019, 9, 4, 16, 5, 7, 123),
                EndTime = new DateTime(2019, 9, 4, 18, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Red"
            };
            dayEntries1.Add(entryModel);

            entryModel = new EntryModel
            {
                Description = "Doing backed",
                Project = "redhat satelite",
                StartTime = new DateTime(2019, 9, 4, 16, 5, 7, 123),
                EndTime = new DateTime(2019, 9, 4, 18, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Red"
            };
            dayEntries1.Add(entryModel);

            this.Add(dayEntries1);


            ObservableCollection<EntryModel> dayEntries2 = new ObservableCollection<EntryModel>();



            entryModel = new EntryModel
            {
                Description = "Second",
                Project = "ITU project",
                StartTime = new DateTime(2019, 9, 3, 16, 5, 7, 123),
                EndTime = new DateTime(2019, 9, 3, 18, 5, 7, 123),
                Duration = new TimeSpan(2, 14, 23),
                Color = "Green"
            };
            dayEntries2.Add(entryModel);


            entryModel = new EntryModel
            {
                Description = "Doing nothung",
                Project = "Secret",
                StartTime = new DateTime(2019, 9, 3, 10, 5, 7, 123),
                EndTime = new DateTime(2019, 9, 3, 13, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Orange"
            };
            dayEntries2.Add(entryModel);

            entryModel = new EntryModel
            {
                Description = "Doing backed",
                Project = "redhat satelite",
                StartTime = new DateTime(2019, 9, 3, 16, 5, 7, 123),
                EndTime = new DateTime(2019, 9, 3, 18, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Red"
            };
            dayEntries2.Add(entryModel);           


            this.Add(dayEntries2);
           

        }

        public ObservableCollection<EntryModel> FirstOrDefault()
        {
            return this.FirstOrDefault();
        }
    }
}
