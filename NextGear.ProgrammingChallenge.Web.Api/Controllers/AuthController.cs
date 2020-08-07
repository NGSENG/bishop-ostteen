using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NextGear.ProgrammingChallenge.Web.Api
{
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("api/authenticate")]
        public IActionResult Authenticate(string username, string password)
        {
            // If the username is equal to admin and the password is equal to Password1, then return Ok();
            if (username == "admin" && password == "Password1")
            {
                return Ok();
            }

            // If the user name does not equal admin and the the password does not equal Password1 then return Forbidden.
            return new StatusCodeResult(StatusCodes.Status403Forbidden);
        }
    }
}
