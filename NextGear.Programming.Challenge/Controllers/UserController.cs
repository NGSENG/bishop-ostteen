//using Microsoft.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NextGear.ProgrammingChallenge.Web.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
