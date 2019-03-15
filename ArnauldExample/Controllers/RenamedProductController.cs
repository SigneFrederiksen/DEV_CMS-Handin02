using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;

namespace ArnauldExample.Controllers
{
    public class RenamedProductController : Controller
    {
        // GET: Product
        public ActionResult Action1()
        {
            CultureInfo[] languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            //ViewBag.Languageslist = languages;
            return View(languages);
        }
    }
}