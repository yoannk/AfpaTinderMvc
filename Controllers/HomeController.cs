using AfpaTinderMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfpaTinderMvc.Controllers
{
    public class HomeController : Controller
    {
        AfpaTinderContext AfpaTinderContext = new AfpaTinderContext();

        public ActionResult Index()
        {
            AfpaTinderContext afpaTinderContext = new AfpaTinderContext();

            AfpaTinderContext.Personnes.Add(new Personne() { Nom = "dfdf", Prenom = "df", Email = "rrrr", Login = "bb", Password = "test2", Statut = true });

            afpaTinderContext.SaveChanges();
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
    }
}