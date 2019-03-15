using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ArnauldExample.Models;
using ArnauldExample.ViewModels.Garage;

namespace ArnauldExample.Controllers
{
    public class GarageController : Controller
    {
        // GET: Garage
        public ActionResult CarsList()
        {
            var factory = new GarageFactory();
            var viewModel = new CarsListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}