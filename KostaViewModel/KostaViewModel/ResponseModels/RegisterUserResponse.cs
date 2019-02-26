using System;
using System.Collections.Generic;
using System.Text;

namespace KostaViewModel.ResponseModels
{
    public class RegisterUserResponse : ResultsModel
    {
        public int UserID { get; set; }
        public string BearerToken { get; set; }
        public string AccountDeleted { get; set; }
    }
}
