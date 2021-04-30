using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using RestSharp;

namespace API_App.Services
{
    public class CallManager
    {

        readonly IRestClient _client;
        public IRestResponse Response { get; set; }

        public HttpStatusCode statusCode { get; set; }

        public ResponseHeaders responseHeaders;

        public CallManager()
        {

            _client = new RestClient(AppConfigReader.BaseUrl);
            responseHeaders = new ResponseHeaders();
        }

        public string MakeSingleLineNameRequest(string lineName)
        {

            var request = new RestRequest();
            request.AddHeader("Content-Type", "Application/json");
            request.Resource = $"Line/{lineName}/Route";
            var response = _client.Execute(request);
            statusCode = response.StatusCode;
            responseHeaders.GetHeaders();
            return response.Content;
        }

    }

}