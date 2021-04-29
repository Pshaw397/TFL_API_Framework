using API_App.Services;
using NUnit.Framework;
using System.Threading.Tasks;

namespace APITests
{
    public class WhenRouteIsCalledWithValidLineName
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
            Assert.That(_singleRouteResponseService.ResponseContent["id"].ToString(), Is.EqualTo("victoria"));
        }

        //[Test]
        //public void CorrectOutcodeIsReturned()
        //{
        //    var result = _lookOutwardCodeService.ResponseContent["result"]["outcode"].ToString();
        //    Assert.That(result, Is.EqualTo("EC2Y"));
        //}

        //[Test]
        //public void ObjectStatusIs200()
        //{
        //    Assert.That(_lookOutwardCodeService.LookOutwardCodeDTO.LookOutwardCode.status, Is.EqualTo(200));
        //}

        //[Test]
        //public void CountAdminWardInthisOutCode()
        //{
        //    var result = _lookOutwardCodeService.LookOutwardCodeDTO.LookOutwardCode.result.admin_ward.Length;
        //    Assert.That(result, Is.EqualTo(6));
        //}
    }
}

