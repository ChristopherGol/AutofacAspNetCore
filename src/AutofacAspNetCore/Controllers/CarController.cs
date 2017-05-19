using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutofacAspNetCore.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AutofacAspNetCore.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService carService;

        // Inject MercedesService instance to controller
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        // GET: /<controller>/
        [HttpGet]
        public string Index()
        {
            string specification=this.carService.PrintSpecification();
            return specification;
        }
    }
}
