using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppReplica.ReplicatedUI.WhatsApp.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {

        #region Fields

        ObservableCollection<SettingsViewModel> _settingsList;

        string _userName;

        string _userAbout;

        string _profilePicSource;

        #endregion


        #region Properties

        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
                base.OnPropertyChanged();
            }
        }


        public string UserAbout
        {
            get
            {
                return _userAbout;
            }

            set
            {
                _userAbout = value;
                base.OnPropertyChanged();
            }
        }


        public string ProfilePicSource
        {
            get
            {
                return _profilePicSource;
            }

            set
            {
                _profilePicSource = value;
                base.OnPropertyChanged();
            }
        }


        public ObservableCollection<SettingsViewModel> SettingsList
        {
            get
            {
                return _settingsList;
            }

            set
            {
                _settingsList = value;
                base.OnPropertyChanged();
            }
        }

        #endregion


        #region Constructors

        public SettingsPageViewModel()
        {

            #region Load & Initialize Data Here

            LoadSettingsList();

            #endregion


        }


        #endregion



        private void LoadSettingsList()
        {
            SettingsList = new ObservableCollection<SettingsViewModel>(GetAllSettings());
        }


        #region Repository

        public List<SettingsViewModel> GetAllSettings()
        {
            List<SettingsViewModel> data = new List<SettingsViewModel>()
            {
                new SettingsViewModel()
                {
                    Title = $"Account",
                    Description = $"Privacy, security, change number",
                    IconSource = $"WhatsAppSettingsAccount.png",
                },

                new SettingsViewModel()
                {
                    Title = $"Chats",
                    Description = $"Theme wallpapers, chat history",
                    IconSource = $"WhatsAppSettingsChat.png",
                },

                new SettingsViewModel()
                {
                    Title = $"Notifications",
                    Description = $"Message, group & call tones",
                    IconSource = $"WhatsAppSettingsNotification.png",
                },

                new SettingsViewModel()
                {
                    Title = $"Data and storage usage",
                    Description = $"Network usage, auto-download",
                    IconSource = $"WhatsAppSettingsDataUsage.png",
                },

                new SettingsViewModel()
                {
                    Title = $"Help",
                    Description = $"FAQ, contact us, privacy policy",
                    IconSource = $"WhatsAppSettingsHelp.png",
                },

            };

            return data;

        }



        #endregion


    }
}
