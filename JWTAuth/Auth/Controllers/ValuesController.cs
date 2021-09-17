using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
 
namespace Auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private Models.ApplicationContext context {get; set;}

        public ValuesController(Models.ApplicationContext ctx)
        {
            context = ctx;
        }
        [Authorize]
        [Route("getlogin")]
        public IActionResult GetLogin()
        {
            return Ok($"Ваш логин: {User.Identity.Name}");
        }
         
        [Authorize(Roles = "Admin")]
        [Route("getrole")]
        public IActionResult GetRole()
        {
            return Ok("Ваша роль: администратор");
        }
    }
}