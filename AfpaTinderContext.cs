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

        //tables Data
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Indesirable> Indesirables { get; set; }

        // tables références
        public DbSet<Loisir> Loisirs { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<TaillePhoto> TaillePhotos { get; set; }
        public DbSet<MotifIndesirable> MotifIndesirables { get; set; }




        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loisir>()
                .HasMany(e => e.Personnes)
                .WithMany(e => e.Loisirs)
                .Map(m => m.ToTable("PersonneLoisir").MapLeftKey("idLoisir").MapRightKey("idPersonne"));

            /*modelBuilder.Entity<Personne>()
                .HasMany(e => e.Favoris)
                .WithMany(e => e.Favoris)
                .Map(m => m.ToTable("Favoris").MapLeftKey("idPersonne").MapRightKey("idPersonneFavoris"));*/
        }
    }

}