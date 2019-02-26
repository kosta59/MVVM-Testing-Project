using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace KostaViewModel.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public string FullnameTxt { get; set; }



        private string _LabelTxt;
        public string LabelTxt
        {
            get { return _LabelTxt; }
            set
            {
                _LabelTxt = value;
                OnPropertyChanged();
            }
        }

        public Command RegisterClicked
        {
            get
            {
                return new Command(() =>
                {
                    LabelTxt = "Hello " + FullnameTxt;
                });
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
