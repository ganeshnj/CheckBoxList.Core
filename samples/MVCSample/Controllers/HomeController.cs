using CheckBoxList.Core.Models;
using Microsoft.AspNetCore.Mvc;
using MVCSample.Bootstrap3.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MVCSample.Bootstrap3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<CheckBoxItem> checkboxItems = new List<CheckBoxItem>()
            {
                new CheckBoxItem(1, "Id 1: Unchecked Enabled", false, false),
                new CheckBoxItem(2, "Id 2: Checked Enabled", true, false),
                new CheckBoxItem(2, "Id 3: Unchecked Disabled", false, true),
                new CheckBoxItem(2, "Id 4: Checked Disabled", true, true)
            };

            return View(checkboxItems);
        }

        public IActionResult Result(List<int> selectedIds)
        {
            return View(selectedIds);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
