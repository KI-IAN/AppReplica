using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace AppReplica.ReplicatedUI.WhatsApp.ViewModels
{
    public class ProfilePopupViewModel : ViewModelBase
    {


        #region Fields

        string _contact;

        string _contactName;

        string _contactNumber;

        string _profilePicSource;

        #endregion


        #region Properties

        public string ProfilePicSource
        {

            get
            {
                return _profilePicSource;
            }

            set
            {
                _profilePicSource = value;
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


        public string Contact
        {

            get
            {
                _contact = String.IsNullOrEmpty(this.ContactName) ? this.ContactNumber : this.ContactName;
                return _contact;
            }

            set
            {
                _contact = value;
                OnPropertyChanged();
            }
        }


        #endregion


        #region Command Properties

        public Command ShowProfilePicCommand { get; }

        #endregion


        #region Constructor(s)

        //Empty Constructor
        public ProfilePopupViewModel()
        {

            #region Attach Event Handlers

            ShowProfilePicCommand = new Command((object parameter) => ShowProfilePic(parameter));

            #endregion

        }



        #endregion


        #region Event Handler Functions

        private async void ShowProfilePic(object parameter)
        {
            var data = (ProfilePopupViewModel)parameter;

            await PopupNavigation.Instance.PopAsync();      //removed the recently opened pop up

            App.NavPage.BarBackgroundColor = Color.Black;       //Change the BarBackGround Color to Black

            await Application.Current.MainPage.Navigation.PushAsync(new UIPages.ProfilePicPage(new ProfilePicViewModel()
            {
                Contact = data.Contact,
                ProfilePicSource = data.ProfilePicSource,
            }));


        }

        #endregion


    }
}
