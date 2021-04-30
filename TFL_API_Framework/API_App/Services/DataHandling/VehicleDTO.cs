using System;
using API_App.Services;
using Newtonsoft.Json;

namespace API_App.Services
{
    public class VehicleDTO
    {
        public VehicleService vehicleService { get; set; }

        public void DeserializeResponse(string vehicleReg)
        {

            vehicleService = JsonConvert.DeserializeObject<VehicleService>(vehicleReg);


        }
    }
}
