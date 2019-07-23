using Microsoft.AspNetCore.Mvc;

namespace AnimalsAPI.Controllers

{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
