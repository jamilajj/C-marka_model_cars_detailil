using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _marka;
        public HomeController()
        {
            _marka = new List<Marka>
            {
                new Marka{Id=1,Name="BMW"},
                new Marka{Id=2,Name="Porsche"}
            };
        }
        public IActionResult Index()
        {
            return View(_marka);
        }
    }
}
