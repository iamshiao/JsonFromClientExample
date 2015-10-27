using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonFromClientExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string hdPeople)
        {
            var lst = JsonConvert.DeserializeObject<List<Person>>(hdPeople);
            lst.RemoveAll(person => person.age < 18);
            return View(lst);
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
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }
}