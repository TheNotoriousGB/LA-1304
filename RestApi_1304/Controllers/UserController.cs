using RestApi_1304.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi_1304.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [Authorize]
        [HttpGet]
        [Route("GetData")]

        public string GetData()
        {
            return "Authenticated with JWT";

        }

        [HttpGet]
        [Route("Details")]

        public string Details()
        {
            return "Autenticated with JWT";
        }

        [Authorize]
        [HttpPost]

        public string AddUser(User user)
        {
            return "User added with username" + user.Username;
        }
    }
}
