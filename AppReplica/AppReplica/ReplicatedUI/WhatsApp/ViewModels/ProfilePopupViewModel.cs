using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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


        #region Constructor(s)

        //Empty Constructor
        public ProfilePopupViewModel()
        {

        }


        //public ProfilePopupViewModel(ProfilePopupViewModel data)
        //{
        //    this.ProfilePicSource = data.ProfilePicSource;
        //    this.ContactName = data.ContactName;
        //    this.ContactNumber = data.ContactNumber;
        //    this.ProfilePicSource = data.ProfilePicSource;
        //}


        #endregion

    }
}
