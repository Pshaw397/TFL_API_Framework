using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_App.Services;
using NUnit.Framework;

namespace TFL_API_TestFramework
{
    class SingleRouteInvalidResponseServiceTest
    {

        SingleRouteResponseService _singleRouteResponseService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _singleRouteResponseService = new SingleRouteResponseService();
            _singleRouteResponseService.MakeRequest("ErrorRequestRoute");
        }

        [Test]
        public void Status404()
        {

            Assert.That(_singleRouteResponseService.numStatusCode, Is.EqualTo(404));

        }


    }
}
