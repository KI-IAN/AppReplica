using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppReplica.ReplicatedUI.WhatsApp.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {

        #region Fields

        string _iconSource;

        string _title;

        string _description;

        string _settingsId;

        #endregion


        #region Properties

        public string IconSource
        {
            get
            {
                return _iconSource;
            }
            set
            {
                _iconSource = value;
                base.OnPropertyChanged();
            }
        }


        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                base.OnPropertyChanged();
            }
        }


        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                base.OnPropertyChanged();
            }
        }


        #endregion




    }
}
