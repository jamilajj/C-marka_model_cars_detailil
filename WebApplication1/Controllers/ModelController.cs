using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;
        public ModelController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1,Name="Sedan",ModelId=1},
                new Model { Id = 2,Name="Jip",ModelId=2},
                 
        };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if(!_models.Exists(m=>m.Id==id))
                {
                    return BadRequest();
                }
                return View(_models.FindAll(m => m.ModelId == id));
            }

            return View(_models);
        }
    }
}
