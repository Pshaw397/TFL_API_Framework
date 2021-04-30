using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_App.Services;
using NUnit.Framework;

namespace TFL_API_TestFramework.Tests
{
    public class UlezVehicleTest
    {

        VehicleService _vehileService;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _vehileService = new VehicleService();
            await _vehileService.MakeRegRequestAsync("FY53UYP");
        }


        [Test]
        public void HttpRequestStatus200()
        {

            Assert.That(_vehileService.numStatusCode, Is.EqualTo(200));

        }

        [Test]
        public void GivenAValidRegistrationNumberReturnsTheVehicleType()
        {
            var result = _vehileService.ResponseContent["type"].ToString();
            Assert.That(result, Is.EqualTo("M1"));
        }

        [Test]
        public void GivenAValidRegistrationNumberReturnsIfULEZComplaint()
        {
            var result = _vehileService.ResponseContent["compliance"].ToString();
            var expected = "Compliant";

            Assert.That(result.Equals(expected));
        }


    }
}
