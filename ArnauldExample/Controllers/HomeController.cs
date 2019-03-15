using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;
using ArnauldExample.ViewModels.Home;
using ArnauldExample.Models;

namespace ArnauldExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchString)
        {
            // Displays a list of products on index page
            var factory = new ShopFactory();
            var products = factory.Products.Where(p => string.IsNullOrEmpty(searchString) || p.Name.Contains(searchString)).OrderBy(p => p.Name).Take(10).ToList();
            //var products = factory.Products.Take(10).ToList();

            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowLanguages()
        {
            var viewModel = new ViewModels.Home.ShowLanguagesViewModel(CultureInfo.GetCultures(CultureTypes.SpecificCultures));

            return View(viewModel);
        }

        public ActionResult ComputeProduct(decimal? number1, decimal? number2)
        {
            var viewModel = new ComputeProductViewModel(number1, number2);

            return View(viewModel);
        }

        // Product details
        public ActionResult Detail(int id)
        {
            // Displays details for each products on index page
            var factory = new ShopFactory();
            var found = factory.Products.Where(p => p.ID == id).FirstOrDefault();

            return View(found);
        }
    }
}