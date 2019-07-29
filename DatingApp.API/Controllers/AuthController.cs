using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class AuthController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}