﻿using System;
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

        public CallManager()
        {

            _client = new RestClient(AppConfigReader.BaseUrl);

        }

        public string MakeSingleLineNameRequest(string lineName)
        {

            var request = new RestRequest();
            request.AddHeader("Content-Type", "Application/json");
            request.Resource = $"Line/{lineName}/Route";
            var response = _client.Execute(request);
            statusCode = response.StatusCode;

            return response.Content;

        }

        public string MakeVehicleRegRequest(string vRegMark)
        {

            var request = new RestRequest();
            request.AddHeader("Content-Type", "Application/json");
            request.Resource = $"Vehicle/UlezCompliance?vrm={vRegMark}";
            var response = _client.Execute(request);
            statusCode = response.StatusCode;

            return response.Content;

        }

    }

}