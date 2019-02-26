using System;
using System.Collections.Generic;
using System.Text;

namespace KostaViewModel.ResponseModels
{
    public class ResultsModel
    {
        public ResultTypes Status { get; set; }
        public string StatusMessage { get; set; }
    }

    public enum ResultTypes
    {
        Success,
        Fail,
        Error,
        Unauthorized,
        DocumentInvalid
    }
}
