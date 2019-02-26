using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KostaViewModel.HttpServices
{
    public class HttpMethods
    {
        private static HttpClient client;

        public HttpMethods()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<string> ServicePostAsync<T>(string url, T t)
        {
            string WebServiceUrl = url;
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await client.PostAsync(WebServiceUrl, httpContent);
            var ResultResponse = await result.Content.ReadAsStringAsync();
            return ResultResponse;
        }

        //public async Task<string> ServicePostAsyncAuthorize<T>(string url, T t)
        //{
        //    string WebServiceUrl = url;
        //    var httpClient = new HttpClient();
        //    httpClient.Timeout = TimeSpan.FromMinutes(30);
        //    var json = JsonConvert.SerializeObject(t);
        //    Debug.WriteLine("HERE 1 " + json, "value");

        //    HttpContent httpContent = new StringContent(json);
        //    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + BearerToken.UserBearerToken);
        //    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    var result = await httpClient.PostAsync(WebServiceUrl, httpContent);
        //    var ResultResponse = await result.Content.ReadAsStringAsync();

        //    return ResultResponse;
        //}

        //public async Task<HttpResponseMessage> ServicePostAsyncAuthorizeParameterOnlyInURL(string url)
        //{
        //    string WebServiceUrl = url;
        //    var httpclient = new HttpClient();
        //    httpclient.DefaultRequestHeaders.Add("Authorization", "Bearer " + BearerToken.UserBearerToken);
        //    var response = await httpclient.PostAsync(WebServiceUrl, null);

        //    return response;
        //}

        //public async Task<string> ServiceGetAsyncAuthorize(string url)
        //{
        //    string WebServiceUrl = url;
        //    Debug.WriteLine(url);
        //    var httpClient = new HttpClient();
        //    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + BearerToken.UserBearerToken);
        //    var response = await httpClient.GetStringAsync(WebServiceUrl);
        //    Debug.WriteLine(response);
        //    return response;
        //}

        public async Task<string> ServiceGetAsync(string url)
        {
            string WebServiceUrl = url;
            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(WebServiceUrl);
            var Result = await httpClient.GetStringAsync(WebServiceUrl);
            return Result;
        }
    }
}
