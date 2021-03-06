using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_App.Services;
using NUnit.Framework;

namespace TFL_API_TestFramework.Tests
{
    public class SingleRouteCentralResponseServiceTest
    {

        SingleRouteResponseService _singleRouteResponseService;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _singleRouteResponseService = new SingleRouteResponseService();
            await _singleRouteResponseService.MakeRequestAsync("Central");
        }

        [Test]
        public void CentralRequestHasStatus200()
        {

            Assert.That(_singleRouteResponseService.numStatusCode, Is.EqualTo(200));

        }

        [Test]
        public void ModelNameIs_Tube()
        {

            Assert.That(_singleRouteResponseService.ResponseContent["modeName"].ToString(), Is.EqualTo("tube"));

        }

        [Test]
        public void WhenRequestIsCentral_RouteSection0Direction_IsEqualToInbound()
        {

            Assert.That(_singleRouteResponseService.ResponseContent["routeSections"][0]["direction"].ToString(), Is.EqualTo("inbound"));

        }

    }
}
