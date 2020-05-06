namespace AfpaTinderMvc
{
    using AfpaTinderMvc.InitDatabase;
    using AfpaTinderMvc.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AfpaTinderContext : DbContext
    {
        public AfpaTinderContext() : base("name=AfpaTinderMvc")
        {
            Database.SetInitializer(new AfpaTinderDbInit());
        }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Loisir> Loisirs { get; set; }
        public DbSet<Ville> Villes { get; set; }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}