using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerITU.Models;

namespace TimeTrackerITU.Helpers
{
    public class SampleEntryModels : ObservableCollection<EntryModel>
    {
        public SampleEntryModels()
        {

            EntryModel entryModel = new EntryModel
            {
                Description = "Doing front end",
                Project = "ITU project",
                StartTime = new DateTime(2008, 3, 9, 16, 5, 7, 123),
                EndTime = new DateTime(2008, 3, 9, 18, 5, 7, 123),
                Duration = new TimeSpan(2, 14, 23),
                Color = "Green"
            };
            this.Add(entryModel);


            entryModel = new EntryModel
            {
                Description = "Doing nothung",
                Project = "Secret",
                StartTime = new DateTime(2008, 3, 9, 10, 5, 7, 123),
                EndTime = new DateTime(2008, 3, 9, 13, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Orange"
            };
            this.Add(entryModel);

            entryModel = new EntryModel
            {
                Description = "Doing backed",
                Project = "redhat satelite",
                StartTime = new DateTime(2008, 3, 9, 16, 5, 7, 123),
                EndTime = new DateTime(2008, 3, 9, 18, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Red"
            };
            this.Add(entryModel);

            entryModel = new EntryModel
            {
                Description = "Doing backed",
                Project = "redhat satelite",
                StartTime = new DateTime(2008, 3, 9, 16, 5, 7, 123),
                EndTime = new DateTime(2009, 3, 9, 18, 5, 7, 123),
                Duration = new TimeSpan(4, 04, 53),
                Color = "Red"
            };
            this.Add(entryModel);
        }
    }
}
