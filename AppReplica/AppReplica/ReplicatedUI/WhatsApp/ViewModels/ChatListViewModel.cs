using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppReplica.ReplicatedUI.WhatsApp.ViewModels
{
    public class ChatListViewModel : INotifyPropertyChanged
    {

        #region Fields

        string _profileImageURL;

        string _contactName;

        string _contactNumber;

        string _lastMessage;

        DateTime _lastMessageDateTime;

        int _totalUnreadMessage;

        bool _showUnreadMessageAlert;

        Enum.EnumMessageStatus _messageStatus;

        #endregion



        #region Properties

        public string ProfileImageURL
        {

            get
            {
                return _profileImageURL;
            }

            set
            {
                _profileImageURL = value;
                OnPropertyChanged();
            }
        }

        public string ContactName
        {

            get
            {
                return _contactName;
            }

            set
            {
                _contactName = value;
                OnPropertyChanged();
            }
        }

        public string ContactNumber
        {

            get
            {
                return _contactNumber;
            }

            set
            {
                _contactNumber = value;
                OnPropertyChanged();
            }
        }


        public string LastMessage
        {

            get
            {
                return _lastMessage;
            }

            set
            {
                _lastMessage = value;
                OnPropertyChanged();
            }
        }

        public DateTime LastMessageDateTime
        {

            get
            {
                return _lastMessageDateTime;
            }

            set
            {
                _lastMessageDateTime = value;
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

        public Enum.EnumMessageStatus MessageStatus
        {

            get
            {
                return _messageStatus;
            }

            set
            {
                _messageStatus = value;
                OnPropertyChanged();
            }
        }


        public bool ShowUnreadMessageAlert
        {

            get
            {
                _showUnreadMessageAlert = TotalUnreadMessage > 0 ? true : false;
                return _showUnreadMessageAlert;
            }

            set
            {
                _showUnreadMessageAlert = value;
                OnPropertyChanged();
            }
        }

        #endregion



        #region Event Handler

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
