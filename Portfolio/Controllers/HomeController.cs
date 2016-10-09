using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult History()
        {
            var vm = new HistoryViewModel
            {
                Title = "Work History",
                Jobs = new List<Job>
            {
                 new Job
                    {
                        Start = DateTime.Now.AddDays(-7),
                        Finish = DateTime.Now,
                        Title = "Wombat Wrangler",
                        Description = "Wrangled many wombats."
                    },
                new Job
                    {
                        Start = DateTime.Now.AddDays(-14),
                        Finish = DateTime.Now.AddDays(-7),
                        Title = "Aardvark Auditor",
                        Description = "Audited many aardvarks."
                    },
                new Job
                    {
                        Start = DateTime.Now.AddDays(-30),
                        Finish = DateTime.Now.AddDays(-14),
                        Title = "Kinkajou Keeper",
                        Description = "Kept many kinkajou (and then set them free)."
                    }
                }
            };
            return View(vm);
        }
    }
}