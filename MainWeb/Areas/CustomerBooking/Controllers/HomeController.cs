using HRIS.Sample.Models;
using Microsoft.AspNetCore.Mvc;

namespace MainWeb.Areas.CustomerBooking.Controllers
{
    [Area("CustomerBooking")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {

            var obj = new V_Number_Temp();
            return View(obj);
        }
    }
}
