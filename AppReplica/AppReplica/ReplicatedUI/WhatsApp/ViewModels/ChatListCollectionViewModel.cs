﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace AppReplica.ReplicatedUI.WhatsApp.ViewModels
{
    public class ChatListCollectionViewModel : INotifyPropertyChanged
    {


        #region Fields

        ObservableCollection<ChatListViewModel> _chatCollection;

        int _totalUnreadMessage;

        bool _isListViewRefreshing;

        int _totalArchivedChat;

        bool _hasArchivedChats;

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
        }


        private async void NavigatePage(object commandParameter)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UIPages.SettingsPages.MainSettingsPage());
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
                    ProfileImageURL = $"{(i <= 12 ? $"Avatar_{new Random().Next(1, 13)}" : "WhatsAppDefaultProfilePic.png")}",
                });
            }

            return data.OrderByDescending(r => r.LastMessageDateTime).ToList();
        }




        #endregion


    }
}
