using System;
using API_App.Services.DataHandling;
using Newtonsoft.Json;

namespace API_App.Services
{
    public class SingleRouteDTO
    {

        public SingleRouteResponse SingleRouteResponse { get; set; }

        public void DeserializeResponse(string lineResponse)
        {

            SingleRouteResponse = JsonConvert.DeserializeObject<SingleRouteResponse>(lineResponse);


        }
    }
}