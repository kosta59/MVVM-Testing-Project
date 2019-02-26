using KostaViewModel.Models;
using KostaViewModel.ResponseModels;
using KostaViewModel.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KostaViewModel.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public RegisterUserPostModel RegisterUserModel { get; set; }

        public BaseViewModel()
        {
            RegisterUserModel = new RegisterUserPostModel();
        }

        public Command RegisterClicked
        {
            get
            {
                return new Command( async () =>
                {
                    RegisterUserModel.DeviceID = "DeviceID1";
                    RegisterUserModel.DeviceType = "Android";
                    RegisterUserModel.SavRAppVersionNumber = 4.0M;

                    await RegisterUser();
                });
            }
        }

        public async Task RegisterUser()
        {
            var RegisterResponse = await new RestServices().RegisterUser(RegisterUserModel);

            switch (RegisterResponse.Status)
            {
                case ResultTypes.Success:
                    break;
                case ResultTypes.Fail:
                    break;
                case ResultTypes.Error:
                    break;
            }
            
        }

















        //public string FullnameTxt { get; set; }

        //private string _LabelTxt;
        //public string LabelTxt
        //{
        //    get { return _LabelTxt; }
        //    set
        //    {
        //        _LabelTxt = value;
        //        OnPropertyChanged();
        //    }
        //}

       


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
