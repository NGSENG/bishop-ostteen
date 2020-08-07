// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

using Microsoft.AspNetCore.Mvc;

namespace NextGear.ProgrammingChallenge.Web.Controllers
{
    [Route("devicemanagement")]
    public class DeviceController : Controller
    {
        [HttpGet]
        [Route("devices")]
        public IActionResult Devices()
        {
            return View();
        }
    }
}
