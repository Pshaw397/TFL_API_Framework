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

        public Dictionary<string, string> responseHeadersDict = new Dictionary<string, string>();

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakeSingleLineNameRequest(string lineName)
        {

            var request = new RestRequest();
            request.AddHeader("Content-Type", "Application/json");
            request.Resource = $"Line/{lineName}/Route";
            var response = await _client.ExecuteAsync(request);
            statusCode = response.StatusCode;
            Response = response;
            GetHeaders();

            return response.Content;

        }

        public async Task<string> MakeVehicleRegRequest(string vRegMark)
        {

            var request = new RestRequest();
            request.AddHeader("Content-Type", "Application/json");
            request.Resource = $"Vehicle/UlezCompliance?vrm={vRegMark}";
            var response = await _client.ExecuteAsync(request);
            statusCode = response.StatusCode;
            Response = response;
            GetHeaders();

            return response.Content;

        }

        public void GetHeaders()
        {
            foreach (var item in Response.Headers)
            {
                string[] pairs = item.ToString().Split('=');
                responseHeadersDict.Add(pairs[0], pairs[1]);
            }
        }
    }

}