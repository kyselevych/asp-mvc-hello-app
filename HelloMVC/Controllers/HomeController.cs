using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Welcome(GuestResponse guestResponse)
        {
            return View("Welcome", guestResponse);
        }
    }
}