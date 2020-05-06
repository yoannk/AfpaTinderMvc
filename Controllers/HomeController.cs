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
            Personne personne = new Personne()
            {
                Nom = "djhrfhjed",
                Prenom = "jjdjkjks",
                Login = ",xxclk",
                Password = "djkfdjkfjkdjk",
                Email = "jdjkdjkjkdkj",
                Statut = true
            };

            Personne personneIndesirable = new Personne()
            {
                Nom = "indesirable",
                Prenom = "pervers",
                Login = ",xxclk",
                Password = "djkfdjkfjkdjk",
                Email = "jdjkdjkjkdkj",
                Statut = true
            };

            AfpaTinderContext.Personnes.Add(personne);
            AfpaTinderContext.Personnes.Add(personneIndesirable);

            MotifIndesirable motifIndesirable = AfpaTinderContext.MotifIndesirables.Find(1);

            Indesirable indesirable = new Indesirable() { Personne = personne, PersonneIndesirable = personneIndesirable, MotifIndesirable = motifIndesirable };
            AfpaTinderContext.Indesirables.Add(indesirable);

            AfpaTinderContext.SaveChanges();
        }
    }
}