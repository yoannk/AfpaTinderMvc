using AfpaTinderMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.InitDatabase
{
    public class AfpaTinderDbInit : DropCreateDatabaseAlways<AfpaTinderContext>
    {
        protected override void Seed(AfpaTinderContext context)
        {
            IList<Personne> personnes = new List<Personne>();
            personnes.Add(new Personne() { Nom = "toto", Prenom = "titi", Email = "dfd", Login = "aa", Password = "test", Statut = true });
            personnes.Add(new Personne() { Nom = "marc", Prenom = "chanois", Email = "rrrr", Login = "bb", Password = "test2", Statut = true });

            context.Personnes.AddRange(personnes);
            base.Seed(context);
        }
    }
}