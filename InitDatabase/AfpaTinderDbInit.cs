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
            /*IList<Personne> personnes = new List<Personne>();
            personnes.Add(new Personne() { Nom = "toto", Prenom = "titi", Email = "dfd", Login = "aa", Password = "test", Statut = true });
            personnes.Add(new Personne() { Nom = "marc", Prenom = "chanois", Email = "rrrr", Login = "bb", Password = "test2", Statut = true });
            context.Personnes.AddRange(personnes);*/

            IList<Loisir> loisirs = new List<Loisir>();
            loisirs.Add(new Loisir() { Nom = "Voile"});
            loisirs.Add(new Loisir() { Nom = "Foot"});
            loisirs.Add(new Loisir() { Nom = "Lecture"});
            context.Loisirs.AddRange(loisirs);

            IList<Ville> villes = new List<Ville>();
            villes.Add(new Ville() { Nom = "Paris", CodePostal = "75000" });
            villes.Add(new Ville() { Nom = "Montpellier", CodePostal = "34000" });
            context.Villes.AddRange(villes);

            IList<TaillePhoto> taillePhotos= new List<TaillePhoto>();
            taillePhotos.Add(new TaillePhoto() { Nom = "Small", Largeur = 300, Hauteur = 200 });
            taillePhotos.Add(new TaillePhoto() { Nom = "Medium", Largeur = 600, Hauteur = 400 });
            taillePhotos.Add(new TaillePhoto() { Nom = "Large", Largeur = 1200, Hauteur = 800 });
            context.TaillePhotos.AddRange(taillePhotos);

            IList<MotifIndesirable> motifIndesirables = new List<MotifIndesirable>();
            motifIndesirables.Add(new MotifIndesirable() { Nom = "Pervers" });
            motifIndesirables.Add(new MotifIndesirable() { Nom = "Harcèlement" });
            motifIndesirables.Add(new MotifIndesirable() { Nom = "Publicité" });
            context.MotifIndesirables.AddRange(motifIndesirables);

            base.Seed(context);
        }
    }
}