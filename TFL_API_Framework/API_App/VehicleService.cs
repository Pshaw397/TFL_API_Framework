using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace API_App.Services
{
    public class VehicleService
    {

        public CallManager CallManager { get; }

        public JObject ResponseContent { get; set; }

        public VehicleDTO VehicleDTO { get; set; }

        public string VehicleRegSelected { get; set; }

        public string VehicleRegResponse { get; set; }

        public int numStatusCode { get; set; }

        public VehicleService()
        {

            CallManager = new CallManager();
            VehicleDTO = new VehicleDTO();

        }

        public async Task MakeRegRequestAsync(string vRegMark)
        {

            VehicleRegSelected = vRegMark;

            VehicleRegResponse = await CallManager.MakeVehicleRegRequest(vRegMark);
            ResponseContent = JObject.Parse(VehicleRegResponse);
            VehicleDTO.DeserializeResponse(VehicleRegResponse);
            numStatusCode = (int)CallManager.statusCode;

        }

    }
}
