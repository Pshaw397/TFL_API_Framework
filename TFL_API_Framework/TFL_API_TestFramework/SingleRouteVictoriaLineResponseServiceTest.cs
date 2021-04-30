using API_App.Services;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace TFL_API_TestFramework
{
    public class SingleRouteVictoriaLineResponseServiceTest
    {
        SingleRouteResponseService _singleRouteResponseService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _singleRouteResponseService = new SingleRouteResponseService();
            _singleRouteResponseService.MakeRequest("Victoria");
        }

        [Test]
        public void StatusIs200()
        {
           
            Assert.That(_singleRouteResponseService.numStatusCode, Is.EqualTo(200));

        }

        [Test]
        public void CorrectLineNameIsReturned()
        {
            var result = _singleRouteResponseService.ResponseContent["id"].ToString();
            Assert.That(result, Is.EqualTo("victoria"));
        }

        [Test]
        public void ReturnTheDirectionOfRouteSections()
        {
            var result = _singleRouteResponseService.ResponseContent["routeSections"][0]["direction"].ToString();
            Assert.That(result, Is.EqualTo("inbound"));
        }

        [Test]
        public void ReturnTheServiceTypeCount()
        {
            var result = _singleRouteResponseService.SingleRouteDTO.SingleRouteResponse.serviceTypes.Length;
            Assert.That(result, Is.EqualTo(2));
        }

    }
}

