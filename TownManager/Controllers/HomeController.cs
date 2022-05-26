using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;
using TownManager.Models.Enums;
using TownManager.Services;
using TownManager.Services.Patterns;

namespace TownManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var gameSingleton = GameSingleton.GetInstance();

            return View(gameSingleton.Model);
        }

        public IActionResult BuildView()
        {
            return View();
        }
        public IActionResult Build(BuildingType id)
        {
            var factory = FactoryMethod.GetBuildingFactory(id);
            factory.Build();

            return RedirectToAction("Index");
        }
        public IActionResult Destroy(int id)
        {
            var gameSingleton = GameSingleton.GetInstance();
            var building = gameSingleton.Model.Buildings[id];

            var factory = FactoryMethod.GetBuildingFactory(building.Type);

            factory.Destroy(id);

            return RedirectToAction("Index");
        }

        public IActionResult NextDay()
        {
            var dayFacade = new DayFacade();
            dayFacade.RecalculateStatistics();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
