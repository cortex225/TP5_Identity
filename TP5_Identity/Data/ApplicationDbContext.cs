using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TP5_Identity.Data.Configuration;
using TP5_Identity.Models;

namespace TP5_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TP5_Identity.Models.Marque> Marques { get; set; }

        public DbSet<TP5_Identity.Models.Modele> Modeles { get; set; }

        public DbSet<TP5_Identity.Models.Client> Clients { get; set; }

        public DbSet<TP5_Identity.Models.Employe> Employes { get; set; }

        public DbSet<TP5_Identity.Models.Location> Locations { get; set; }

        public DbSet<TP5_Identity.Models.Voiture> Voitures { get; set; }

        public DbSet<TP5_Identity.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<TP5_Identity.Models.Abonnement> Abonnements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Ajout des abonnements à la base de donnée
            modelBuilder.ApplyConfiguration(new AbonnementsConfiguration());

            // Pour création de la BD en table
            modelBuilder.Entity<Client>().ToTable(nameof(Clients));
            modelBuilder.Entity<Employe>().ToTable(nameof(Employes));




            // Créer les rôles

            IdentityRole admin = new IdentityRole { Name = "admin", NormalizedName = "admin".ToUpper() };
            modelBuilder.Entity<IdentityRole>().HasData(admin);
            IdentityRole employe = new IdentityRole { Name = "employe", NormalizedName = "employe".ToUpper() };
            modelBuilder.Entity<IdentityRole>().HasData(employe);
            IdentityRole client = new IdentityRole { Name = "client", NormalizedName = "client".ToUpper() };
            modelBuilder.Entity<IdentityRole>().HasData(client);

            //Création des différent comptes
            //var password = new PasswordHasher<ApplicationUser>();
            ApplicationUser UserAdmin = new ApplicationUser
            {


                Email = "admin@admin.com",
                UserName = "admin@admin.com",
                NormalizedEmail = "admin@admin.com".ToUpper(),
                NormalizedUserName = "admin@admin.com".ToUpper(),
               
            };
            //var adminHasher = password.HashPassword(UserAdmin, "Jaimelaprog1!");
            UserAdmin.PasswordHash = "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==";
            modelBuilder.Entity<ApplicationUser>().HasData(UserAdmin);


            ApplicationUser UserEmploye = new ApplicationUser
            {


                Email = "employe@employe.com",
                UserName = "employe@employe.com",
                NormalizedEmail = "employe@employe.com".ToUpper(),
                NormalizedUserName = "employe@employe.com".ToUpper()
            };
           // var employeHasher = password.HashPassword(UserEmploye, "Jaimelaprog1!");
            UserEmploye.PasswordHash = "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==";
            modelBuilder.Entity<ApplicationUser>().HasData(UserEmploye);


            ApplicationUser UserClient = new ApplicationUser
            {


                Email = "client@client.com",
                UserName = "client@client.com",
                NormalizedEmail = "client@client.com".ToUpper(),
                NormalizedUserName = "client@client.com".ToUpper()
            };
            //var ClientHasher = password.HashPassword(UserClient, "Jaimelaprog1!");
            UserClient.PasswordHash = "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==";
            modelBuilder.Entity<ApplicationUser>().HasData(UserClient);



            //Connecte les rôles aux users pré-créés
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = admin.Id, UserId = UserAdmin.Id },
                new IdentityUserRole<string>() { RoleId = employe.Id, UserId = UserEmploye.Id },
                new IdentityUserRole<string>() { RoleId = client.Id, UserId = UserClient.Id }
                );
          


        }
    }
}
