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
            InitDb();
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

        private void InitDb()
        {
            //afpaTinderContext.Villes.Add(new Ville() { Nom = "Lille", CodePostal = "59000" });

            Personne personne = new Personne()
            {
                Nom = "djhrfhjed",
                Prenom = "jjdjkjks",
                Login = ",xxclk",
                Password = "djkfdjkfjkdjk",
                Email = "jdjkdjkjkdkj",
                Statut = true
            };

            Loisir loisir = new Loisir() { Nom = "voile" };

            personne.Loisirs.Add(loisir);
            AfpaTinderContext.Personnes.Add(personne);

            AfpaTinderContext.SaveChanges();
        }
    }
}