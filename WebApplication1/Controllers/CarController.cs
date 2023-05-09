using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Cars> _cars;  
        public CarController()
        {
            _cars = new List<Cars>
            {
                new Cars {Id=1,Name="A500",CarId=1},
                new Cars {Id=2,Name="b500",CarId=2},
                new Cars {Id=3,Name="benz",CarId=2},
            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (!_cars.Exists(car => car.Id == id))
                {
                    return BadRequest();
                }
                return View(_cars.FindAll(car => car.CarId == id));
            }

            return View(_cars);
        }

        public IActionResult Detail(int? id) 
        {
            if (id != null) return BadRequest();
            Cars car=_cars.Find(c => c.Id == id);
            if(car==null) return NotFound();
            return View(car);

        }
    }
} 
