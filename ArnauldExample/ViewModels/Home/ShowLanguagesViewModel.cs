using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Globalization;

namespace ArnauldExample.ViewModels.Home
{
    public class ShowLanguagesViewModel
    {
        public IEnumerable<SelectListItem> CulturesList { get; private set; }

        public ShowLanguagesViewModel(CultureInfo[] cultures)
        {
            CulturesList = cultures.Select(c => new SelectListItem() { Text = c.EnglishName });
        }
    }
}