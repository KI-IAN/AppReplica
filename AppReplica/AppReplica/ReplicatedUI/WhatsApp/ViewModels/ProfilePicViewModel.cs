using System;
using System.Collections.Generic;
using System.Text;

namespace AppReplica.ReplicatedUI.WhatsApp.ViewModels
{
    public class ProfilePicViewModel : ViewModelBase
    {

        #region Fields

        string _profilePicSource;

        string _contact;

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
                base.OnPropertyChanged();
            }
        }


        public string Contact
        {

            get
            {
                return _contact;
            }

            set
            {
                _contact = value;
                base.OnPropertyChanged();
            }
        }

        #endregion

    }
}
