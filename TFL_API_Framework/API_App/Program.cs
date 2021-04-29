using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace API_App
{
    public class Program
    {

        public static void Main()
        {

            var client = new RestClient("https://api.tfl.gov.uk/Road/");

            client.Timeout = -1;

                var request = new RestRequest(Method.GET);

            request.AddHeader("Cookie", "__cfduid=dffc4671e9d499370756de9491d0f7a901619616500");

                IRestResponse response = client.Execute(request);
            
            Console.WriteLine(response.Content);

        }


    }
}
