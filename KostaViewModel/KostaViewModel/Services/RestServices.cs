using KostaViewModel.HttpServices;
using KostaViewModel.Models;
using KostaViewModel.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KostaViewModel.Services
{
    public class RestServices
    {

        public string BaseUrlDotNetCore = "https://savrusapi.azurewebsites.net";

        public async Task<RegisterUserResponse> RegisterUser(RegisterUserPostModel Model)
        {
            var json = await new HttpMethods().ServicePostAsync(BaseUrlDotNetCore + "/api/v4/RegisterUser", Model);
            RegisterUserResponse Response = JsonConvert.DeserializeObject<RegisterUserResponse>(json);
            return Response;
        }

    }
}
