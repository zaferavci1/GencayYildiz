using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using View.Models;

namespace View.Controllers
{
    public class HomeController : Controller
    {
        // .cshtml .net core'a özgüdür.
        //cshtml dosyaları render edildikten sonra çıktı olarak html dosyası verir.
        //hazır templateler fazldan maliyet getirir.
        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Index3()
        {
            return View();
        }
    }
}
