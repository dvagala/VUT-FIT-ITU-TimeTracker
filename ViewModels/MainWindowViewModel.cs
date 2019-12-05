using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TimeTrackerITU.Commands;
using TimeTrackerITU.Models;
using TimeTrackerITU.Helpers;

namespace TimeTrackerITU.ViewModels
{
    
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public ICommand ProceedLoginCommand { get; }
        public ICommand ProceedLogoutCommand { get; }
        public ICommand OpenSettingsCommand { get; }
        public ICommand CloseSettingsCommand { get; }
        public ICommand OpenEntryDetailCommand { get; }
        public ICommand CloseEntryDetailCommand { get; }
        public ICommand OpenAddTimeManuallyCommand { get; }
        public ICommand CloseAddTimeManuallyCommand { get; }
        public ICommand OpenEditEntryCommand { get; }
        public ICommand CloseEditEntryCommand { get; }


        public ObservableCollection<EntryModel> Entries { get; set; } = new SampleEntryModels();

        public ObservableCollection<String> RecentProjects { get; set; } = new ObservableCollection<String>() { "ITU project", "redhat satelite" };

        public ObservableCollection<String> RecentDescriptions { get; set; } = new ObservableCollection<String>() { "Doing backed", "redhat satelite" };

        public string SelectedPoject { get; set; } = "ITU project";

        public string SelectedDescription { get; set; } = "Doing backed";

        

        private EntryModel selectedEntry = new EntryModel();
        public EntryModel SelectedEntry 
        {
            get => selectedEntry; set
            {
                selectedEntry = value;
                OnPropertyChanged("SelectedEntry");
            }
        }


        private bool overlayIsOpen = false;
        public bool OverlayIsOpen
        {
            get => overlayIsOpen; set
            {
                overlayIsOpen = value;
                OnPropertyChanged("OverlayIsOpen");
            }
        }


        private bool settingsAreOpen = false;
        public bool SettingsAreOpen
        {
            get => settingsAreOpen; set
            {
                settingsAreOpen = value;
                OnPropertyChanged("SettingsAreOpen");
            }
        }


        private bool entryDetailIsOpen = false;
        public bool EntryDetailIsOpen
        {
            get => entryDetailIsOpen; set
            {
                entryDetailIsOpen = value;
                OnPropertyChanged("EntryDetailIsOpen");
            }
        }



        private bool addTimeManuallyIsOpen = false;
        public bool AddTimeManuallyIsOpen
        {
            get => addTimeManuallyIsOpen; set
            {
                addTimeManuallyIsOpen = value;
                OnPropertyChanged("AddTimeManuallyIsOpen");
            }
        }

        private bool editEntryIsOpen = false;
        public bool EditEntryIsOpen
        {
            get => editEntryIsOpen; set
            {
                editEntryIsOpen = value;
                OnPropertyChanged("EditEntryIsOpen");
            }
        }


        private bool userIsLoggedIn = false;
        public bool UserIsLoggedIn
        {
            get => userIsLoggedIn; set
            {
                userIsLoggedIn = value;
                OnPropertyChanged("UserIsLoggedIn");
            }
        }

        public MainWindowViewModel()
        {
            ProceedLoginCommand = new AsyncCommand<string>(mockupString => ProceedLogin());
            ProceedLogoutCommand = new AsyncCommand<string>( mockupString =>  ProceedLogout());
            OpenSettingsCommand = new AsyncCommand<string>(mockupString => OpenSettings());
            CloseSettingsCommand = new AsyncCommand<string>(mockupString => CloseSettings());
            OpenEntryDetailCommand = new AsyncCommand<EntryModel>(selectedEntry => OpenEntryDetail(selectedEntry));
            CloseEntryDetailCommand = new AsyncCommand<EntryModel>(selectedEntry => CloseEntryDetail());
            OpenAddTimeManuallyCommand = new AsyncCommand<string>(mockupString => OpenAddTimeManually());
            CloseAddTimeManuallyCommand = new AsyncCommand<string>(mockupString => CloseAddTimeManually());
            OpenEditEntryCommand = new AsyncCommand<string>(mockupString => OpenEditEntry());
            CloseEditEntryCommand = new AsyncCommand<string>(mockupString => CloseEditEntry());
        }



        public async Task ProceedLogout()
        {
            UserIsLoggedIn = false;
            CloseSettings();
        }

        public async Task ProceedLogin()
        {
            UserIsLoggedIn = true;
        }

        public async Task OpenSettings()
        {
            OverlayIsOpen = true;
            SettingsAreOpen = true;
        }

        public async Task CloseSettings()
        {
            OverlayIsOpen = false;
            SettingsAreOpen = false;
        }
        public async Task OpenAddTimeManually()
        {
            OverlayIsOpen = true;
            AddTimeManuallyIsOpen = true;
        }

        public async Task CloseAddTimeManually()
        {
            OverlayIsOpen = false;
            AddTimeManuallyIsOpen = false;
        }

        public async Task OpenEditEntry()
        {
            OverlayIsOpen = true;
            EditEntryIsOpen = true;
        }

        public async Task CloseEditEntry()
        {
            OverlayIsOpen = false;
            EditEntryIsOpen = false;
        }


        public async Task OpenEntryDetail(EntryModel selectedEntry)
        {
            SelectedEntry = selectedEntry;
            OverlayIsOpen = true;
            EntryDetailIsOpen = true;
        }

        public async Task CloseEntryDetail()
        {
            OverlayIsOpen = false;
            EntryDetailIsOpen = false;
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}