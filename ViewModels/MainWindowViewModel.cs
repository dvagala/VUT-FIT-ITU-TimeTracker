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
        public ICommand RunTimerCommand { get; }
        public ICommand StopTimerCommand { get; }
        public ICommand OpenProjectOverviewCommand { get; }
        public ICommand CloseProjectOverviewCommand { get; }
        public ICommand OpenEditStartTimeCommand { get; }
        public ICommand CloseEditStartTimeCommand { get; }
        public ICommand AddNewEntryCommand { get; }




        public ObservableCollection<EntryModel> Entries { get; set; } = new SampleEntryModels();

        public ObservableCollection<UserModel> Users { get; set; } = new SampleUserModels();

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

        private bool userIsNotLoggedIn = true;
        public bool UserIsNotLoggedIn
        {
            get => userIsNotLoggedIn; set
            {
                userIsNotLoggedIn = value;
                OnPropertyChanged("UserIsNotLoggedIn");
            }
        }

        private bool timerIsRunning = false;
        public bool TimerIsRunning
        {
            get => timerIsRunning; set
            {
                timerIsRunning = value;
                OnPropertyChanged("TimerIsRunning");
            }
        }

        private bool timerIsStopped = true;
        public bool TimerIsStopped
        {
            get => timerIsStopped; set
            {
                timerIsStopped = value;
                OnPropertyChanged("TimerIsStopped");
            }
        }

        private bool projectOverviewIsOpen = false;
        public bool ProjectOverviewIsOpen
        {
            get => projectOverviewIsOpen; set
            {
                projectOverviewIsOpen = value;
                OnPropertyChanged("EditEntryIsOpen");
            }
        }
      
        private bool editStartTimeIsOpen = false;
        public bool EditStartTimeIsOpen
        {
            get => editStartTimeIsOpen; set
            {
                editStartTimeIsOpen = value;
                OnPropertyChanged("EditStartTimeIsOpen");
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
            RunTimerCommand = new AsyncCommand<string>(mockupString => RunTimer());
            StopTimerCommand = new AsyncCommand<string>(mockupString => StopTimer());
            OpenProjectOverviewCommand = new AsyncCommand<string>(mockupString => OpenProjectOverview());
            CloseProjectOverviewCommand = new AsyncCommand<string>(mockupString => CloseProjectOverview());
            OpenEditStartTimeCommand = new AsyncCommand<string>(mockupString => OpenEditStartTime());
            CloseEditStartTimeCommand = new AsyncCommand<string>(mockupString => CloseEditStartTime());
        }

        
        public async Task ProceedLogout()
        {
            UserIsLoggedIn = false;
            UserIsNotLoggedIn = true;
            CloseSettings();
            StopTimer();
        }

        public async Task ProceedLogin()
        {
            UserIsLoggedIn = true;
            UserIsNotLoggedIn = false;
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
            if (EntryDetailIsOpen)
            {
                OverlayIsOpen = true;
            }
            else
            {
                OverlayIsOpen = false;
            }
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
        public async Task RunTimer()
        {
            TimerIsRunning = true;
            TimerIsStopped = false;
        }
        public async Task StopTimer()
        {
            TimerIsRunning = false;
            TimerIsStopped = true;
        }
        public async Task OpenProjectOverview()
        {
            ProjectOverviewIsOpen = true;
            OverlayIsOpen = true;
        }
        public async Task CloseProjectOverview()
        {
            ProjectOverviewIsOpen = false;
            OverlayIsOpen = false;
        }

        public async Task OpenEditStartTime()
        {
            EditStartTimeIsOpen = true;
            OverlayIsOpen = true;
        }
        public async Task CloseEditStartTime()
        {
            EditStartTimeIsOpen = false;
            OverlayIsOpen = false;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}