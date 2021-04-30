using API_App.Services;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace APITests
{
    public class WhenRouteIsCalledWithValidLineName
    {
        SingleRouteResponseService _singleRouteResponseService;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _singleRouteResponseService = new SingleRouteResponseService();
            await _singleRouteResponseService.MakeRequestAsync("Bakerloo");
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_singleRouteResponseService.numStatusCode, Is.EqualTo(200));
        }

        [Test]
        public void WhenRequestIsBakerloo_idIsbakerloo()
        {
            Assert.That(_singleRouteResponseService.ResponseContent["id"].ToString(), Is.EqualTo("bakerloo"));
        }

        [Test]
        public void WhenRequestIsBakerloo_DirectionOfRouteSection0_IsInbound()
        {
            Assert.That(_singleRouteResponseService.SingleRouteDTO.SingleRouteResponse.routeSections[0].direction, Is.EqualTo("inbound"));
        }

        [Test]
        public void WhenRequestIsBakerloo_DirectionOfRouteSection1_IsOutbound()
        {
            Assert.That(_singleRouteResponseService.SingleRouteDTO.SingleRouteResponse.routeSections[1].direction, Is.EqualTo("outbound"));
        }

        [Test]
        public void WhenRequestIsBakerloo_OriginatorOfRouteSection1_Is940GZZLUEAC()
        {
            Assert.That(_singleRouteResponseService.SingleRouteDTO.SingleRouteResponse.routeSections[1].originator, Is.EqualTo("940GZZLUEAC"));
        }

        [Test]
        public void HeaderTest()
        {
            Assert.That(_singleRouteResponseService.CallManager.responseHeadersDict["Content-Length"], Is.EqualTo("432"));
        }

    }
}

