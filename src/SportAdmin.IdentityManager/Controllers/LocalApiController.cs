
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static IdentityServer4.IdentityServerConstants;

namespace SportAdmin.IdentityManager.Controllers
{
    [Route("api/{controller}")]
    [Authorize(LocalApi.PolicyName)]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }
    }
}
