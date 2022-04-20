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
        public DbSet<TP5_Identity.Models.Client> Clients { get; set; }

        public DbSet<TP5_Identity.Models.Employe> Employes { get; set; }

        public DbSet<TP5_Identity.Models.Location> Locations { get; set; }

        public DbSet<TP5_Identity.Models.Voiture> Voitures { get; set; }

        public DbSet<TP5_Identity.Models.Marque> Marques { get; set; }

        public DbSet<TP5_Identity.Models.Modele> Modeles { get; set; }

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

            const string USER_ADMIN_ID = "32e55894137a1c163a81836e815d4ad0";
            const string USER_EMP_ID = "2d15691c418237479115a3618b0009ee8acb1a80";
            const string USER_CLT_ID = "9faf91e5284627fc1e07d6884be54d4098f24fd6";
            

            // Créer le rôle
            modelBuilder.Entity<IdentityRole>().HasData(
                        new IdentityRole()
                        {
                            Id = USER_ADMIN_ID,
                            Name = "admin",
                            NormalizedName = "admin".ToUpper(),

                        },
                        new IdentityRole()
                        {
                            Id = USER_EMP_ID,
                            Name = "employe",
                            NormalizedName = "employe".ToUpper(),

                        },
                       new IdentityRole()
                       {
                           Id = USER_CLT_ID,
                           Name = "client",
                           NormalizedName = "client".ToUpper(),

                       }
                );

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(

            new ApplicationUser
            {
                Id = USER_ADMIN_ID,
                UserName = "administrateur",
                NormalizedUserName = "administrateur",
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Jaimelaprog1!"),
                SecurityStamp = string.Empty,
                
            },
            new ApplicationUser
            {
                Id = USER_EMP_ID,
                UserName = "employe",
                NormalizedUserName = "employe",
                Email = "emp@emp.com",
                NormalizedEmail = "emp@emp.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Jaimelaprog1!"),
                SecurityStamp = string.Empty
            },
            new ApplicationUser
            {
                Id = USER_CLT_ID,
                UserName = "client",
                NormalizedUserName = "client",
                Email = "client@client.com",
                NormalizedEmail = "client@client.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Jaimelaprog1!"),
                SecurityStamp = string.Empty

            });

          

            // Ajouter les rôles de l'utilisateur.
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = USER_ADMIN_ID,
                UserId = USER_ADMIN_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = USER_EMP_ID,
                UserId = USER_EMP_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = USER_CLT_ID,
                UserId = USER_CLT_ID
            }
            );
        }
    }
}
