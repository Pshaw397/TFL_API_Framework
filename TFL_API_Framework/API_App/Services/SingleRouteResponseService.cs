using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace API_App.Services
{
    public class SingleRouteResponseService
    {

        public CallManager CallManager { get; }
        public JObject ResponseContent { get; set; }

        public SingleRouteDTO SingleRouteDTO  { get; set; }

        public string LineSelected { get; set; }

        public string LineResponse { get; set; }

        public SingleRouteResponseService()
        {

            CallManager = new CallManager();
            SingleRouteDTO = new SingleRouteDTO();

        }

        public void MakeRequest(string lineName)
        {

            LineSelected = lineName;

            LineResponse = CallManager.MakeSingleLineNameRequest(lineName);
            ResponseContent = JObject.Parse(LineResponse);
            SingleRouteDTO.DeserializeResponse(LineResponse); 

        }

    }
}
