using Microsoft.AspNetCore.Mvc;

namespace GitExample1.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return Content("Branch1");
        }
    }
}
