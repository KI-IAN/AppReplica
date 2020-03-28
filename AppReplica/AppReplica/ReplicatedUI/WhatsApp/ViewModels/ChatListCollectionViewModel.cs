using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

namespace AppReplica.ReplicatedUI.WhatsApp.ViewModels
{
    public class ChatListCollectionViewModel : INotifyPropertyChanged
    {


        #region Fields

        ObservableCollection<ChatListViewModel> _chatCollection;

        ObservableCollection<ChatListViewModel> _tempAllChatCollection;

        int _totalUnreadMessage;

        bool _isListViewRefreshing;

        int _totalArchivedChat;

        bool _hasArchivedChats;

        string _searchString = String.Empty;

        #endregion



        #region Properties

        public ObservableCollection<ChatListViewModel> ChatCollection
        {

            get
            {
                return _chatCollection;
            }

            set
            {
                _chatCollection = value;
                OnPropertyChanged();
            }
        }


        public int TotalUnreadMessage
        {

            get
            {
                return _totalUnreadMessage;
            }

            set
            {
                _totalUnreadMessage = value;
                OnPropertyChanged();
            }
        }


        public bool IsListViewRefreshing
        {

            get
            {
                return _isListViewRefreshing;
            }

            set
            {
                _isListViewRefreshing = value;
                OnPropertyChanged();
            }
        }

        public Command RefreshListCommand { get; }

        public Command NavigatePageCommand { get; }

        public Command PopupProfileCommand { get; }

        public Command SearchCommand { get; }

        public int TotalArchivedChat
        {

            get
            {
                return _totalArchivedChat;
            }

            set
            {
                _totalArchivedChat = value;
                OnPropertyChanged();
            }
        }


        public bool HasArchivedChats
        {
            get
            {
                return _hasArchivedChats;
            }

            set
            {
                _hasArchivedChats = value;
                OnPropertyChanged();
            }


        }


        public string SearchString
        {
            get
            {
                return _searchString;
            }
            set
            {
                _searchString = value;

                Search(_searchString);

                OnPropertyChanged();
            }
        }

        #endregion


        #region Constructor

        public ChatListCollectionViewModel()
        {
            #region Initialize Data

            LoadListData();

            #endregion

            #region Attaching Command Handlers

            RefreshListCommand = new Command(LoadListData);

            NavigatePageCommand = new Command((object parameter) => NavigatePage(parameter));

            PopupProfileCommand = new Command((object parameter) => PopupProfile(parameter));

            SearchCommand = new Command((object parameter) => Search(parameter));

            #endregion


        }

        #endregion



        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        #region Event Handler

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion



        #region Command Handler Function


        private void LoadListData()
        {
            ChatCollection = new ObservableCollection<ChatListViewModel>(GetAllChat());
            TotalUnreadMessage = ChatCollection.Where(r => r.TotalUnreadMessage > 0).Count();
            TotalArchivedChat = new Random().Next(0, 5);
            HasArchivedChats = TotalArchivedChat > 0 ? true : false;
            IsListViewRefreshing = false;
            _tempAllChatCollection = _chatCollection;
        }


        private async void NavigatePage(object commandParameter)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UIPages.SettingsPages.MainSettingsPage());
        }


        private async void PopupProfile(object parameter)
        {
            ChatListViewModel data = (ChatListViewModel)parameter;

            await PopupNavigation.Instance.PushAsync(new UIPages.ProfilePopupPage(new ProfilePopupViewModel()
            {
                ContactName = data.ContactName,
                ContactNumber = data.ContactNumber,
                ProfilePicSource = data.ProfileImageURL,
            }));
        }


        private void Search(object parameter)
        {
            string searchString = parameter.ToString();

            if (!String.IsNullOrEmpty(searchString))
            {

                var filteredData = _tempAllChatCollection.Where(
                    r => (!String.IsNullOrEmpty(r.ContactName) && r.ContactName.ToLower().Contains(searchString))
                    || (!String.IsNullOrEmpty(r.ContactNumber) && r.ContactNumber.ToLower().Contains(searchString)))
                    .ToList();

                ChatCollection = new ObservableCollection<ChatListViewModel>(filteredData);
            }
            else
            {
                ChatCollection = _tempAllChatCollection;
            }
        }


        #endregion


        #region Repository

        private List<ChatListViewModel> GetAllChat()
        {

            List<ChatListViewModel> data = new List<ChatListViewModel>();

            for (int i = 1; i <= new Random().Next(15, 30); i++)
            {
                data.Add(new ChatListViewModel()
                {
                    ContactNumber = $"+{new Random().Next(1, 99)} {new Random().Next(10000, 99999)} {new Random().Next(1000, 9999)}",
                    ContactName = $"{(new Random().Next(1, 3) == 2 ? $"Contact Name#{i}" : String.Empty)}",
                    LastMessage = $"Some random message text...",
                    LastMessageDateTime = new DateTime(new Random().Next(2013, 2021), new Random().Next(1, 11), new Random().Next(1, 28),
                                                        new Random().Next(1, 22), new Random().Next(1, 59), new Random().Next(1, 59)),
                    MessageStatus = (Enum.EnumMessageStatus)new Random().Next(1, 3),
                    TotalUnreadMessage = (new Random().Next(0, 30) <= 10 ? 0 : new Random().Next(11, 30)),
                    ProfileImageURL = $"{(i <= 19 ? $"Avatar_{new Random().Next(1, 20)}" : "WhatsAppDefaultProfilePic.png")}",
                });
            }

            return data.OrderByDescending(r => r.LastMessageDateTime).ToList();
        }




        #endregion


    }
}
