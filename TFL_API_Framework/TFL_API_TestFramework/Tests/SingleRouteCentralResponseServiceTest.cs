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
        public void OneTimeSetUp()
        {
            _singleRouteResponseService = new SingleRouteResponseService();
            _singleRouteResponseService.MakeRequest("Central");
        }

        [Test]
        public void ModelNameIs_Tube()
        {

            Assert.That(_singleRouteResponseService.ResponseContent["modeName"].ToString(), Is.EqualTo("tube"));

        }

    }
}
