using System;
using System.Collections.Generic;
using System.Text;

namespace KostaViewModel.Models
{
    public class RegisterUserPostModel
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string DeviceID { get; set; }
        public string DeviceType { get; set; }
        public decimal SavRAppVersionNumber { get; set; }
    }
}
