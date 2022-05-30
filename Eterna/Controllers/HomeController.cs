using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public object HomeViewModel { get; private set; }

        public IActionResult Index()
        {
            List<Feature> features = new List<Feature>
            {
                new Feature(1,"bi bi-card-checklist","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"),
                new Feature(2,"bi bi-bar-chart","Dolor Sitema","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"),
                new Feature(3,"bi bi-binoculars","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident")
            };

            List<Service> services = new List<Service>
            {
                new Service(1,"bx bxl-dribbble","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(2,"bx bx-file","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(3,"bx bx-tachometer","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(4,"bx bx-world","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(5,"bx bx-slideshow","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(6,"bx bx-arch","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi")
            };

            HomeVIewModel homeViewModel = new HomeVIewModel()
            {
                Features = features,
                Services = services
            };
            return View(homeViewModel);
        }

        public IActionResult DetailF(int id)
        {
            List<Feature> features = new List<Feature>
            {
                new Feature(1,"bi bi-card-checklist","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"),
                new Feature(2,"bi bi-bar-chart","Dolor Sitema","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"),
                new Feature(3,"bi bi-binoculars","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident")
            };

            var element = features.Find(x => x.Id == id);

            return View(element);
        }

        public IActionResult DetailS(int id)
        {
            List<Service> services = new List<Service>
            {
                new Service(1,"bx bxl-dribbble","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(2,"bx bx-file","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(3,"bx bx-tachometer","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(4,"bx bx-world","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(5,"bx bx-slideshow","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
                new Service(6,"bx bx-arch","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi")
            };

            var element = services.Find(x => x.Id == id);

            return View(element);
        }
    }
}
