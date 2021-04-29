using API_App.Services;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace APITests
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
        public void ReturnTheCountOfRouteSections()
        {
            //var result = _singleRouteResponseService.ResponseContent["routeSections"];
            //Assert.That(result, Is.EqualTo(2));
        }

    }
}

