using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using TP5_Identity.Data;
using TP5_Identity.Models;

namespace Seeder
{
    class Program
    {
        public static void Main()
        {
            using ApplicationDbContext context = DbContextFactory.CreateDbContext();

            context.Locations.RemoveRange(context.Locations);
            context.Voitures.RemoveRange(context.Voitures);
            context.Modeles.RemoveRange(context.Modeles);
            context.Marques.RemoveRange(context.Marques);
            context.SaveChanges();

            List<Marque> marques = new()
            {
                new Marque { Nom = "Toyota" },
                new Marque { Nom = "Nissan" },
                new Marque { Nom = "Honda" },
                new Marque { Nom = "Ford" },
                new Marque { Nom = "GMC" },
                new Marque { Nom = "BMW" },
                new Marque { Nom = "Audi" },
                new Marque { Nom = "Mercedes" },
            };
            context.Marques.AddRange(marques);
            context.SaveChanges();

            List<Modele> modeles = new()
            {
                new Modele { Nom = "Rav4", Marque = marques.ElementAt(0) },
                new Modele { Nom = "Corolla", Marque = marques.ElementAt(0) },
                new Modele { Nom = "Prius", Marque = marques.ElementAt(0) },
                new Modele { Nom = "Camry", Marque = marques.ElementAt(0) },
                new Modele { Nom = "Rogue", Marque = marques.ElementAt(1) },
                new Modele { Nom = "Sentra", Marque = marques.ElementAt(1) },
                new Modele { Nom = "350Z", Marque = marques.ElementAt(1) },
                new Modele { Nom = "Altima", Marque = marques.ElementAt(1) },
                new Modele { Nom = "Civic", Marque = marques.ElementAt(2) },
                new Modele { Nom = "CRV", Marque = marques.ElementAt(2) },
                new Modele { Nom = "Accord", Marque = marques.ElementAt(2) },
                new Modele { Nom = "Pilot", Marque = marques.ElementAt(2) },
                new Modele { Nom = "Focus", Marque = marques.ElementAt(3) },
                new Modele { Nom = "Escape", Marque = marques.ElementAt(3) },
                new Modele { Nom = "F-150", Marque = marques.ElementAt(3) },
                new Modele { Nom = "Mustang", Marque = marques.ElementAt(3) },
                new Modele { Nom = "Acadia", Marque = marques.ElementAt(4) },
                new Modele { Nom = "Yukon", Marque = marques.ElementAt(4) },
                new Modele { Nom = "Sierra", Marque = marques.ElementAt(4) },
                new Modele { Nom = "Canyon", Marque = marques.ElementAt(4) },
                new Modele { Nom = "X5", Marque = marques.ElementAt(5) },
                new Modele { Nom = "M3", Marque = marques.ElementAt(5) },
                new Modele { Nom = "i3", Marque = marques.ElementAt(5) },
                new Modele { Nom = "230i", Marque = marques.ElementAt(5) },
                new Modele { Nom = "A4", Marque = marques.ElementAt(6) },
                new Modele { Nom = "Q3", Marque = marques.ElementAt(6) },
                new Modele { Nom = "TT", Marque = marques.ElementAt(6) },
                new Modele { Nom = "A8", Marque = marques.ElementAt(6) },
                new Modele { Nom = "E300", Marque = marques.ElementAt(7) },
                new Modele { Nom = "C300", Marque = marques.ElementAt(7) },
                new Modele { Nom = "A220", Marque = marques.ElementAt(7) },
                new Modele { Nom = "S560", Marque = marques.ElementAt(7) }
            };
            context.Modeles.AddRange(modeles);
            context.SaveChanges();

            var yearGenerator = new RandomGenerator();
            var priceGenerator = new RandomGenerator();
            List<string> couleurs = new() { "Noir", "Rouge", "Bleu", "Vert", "Gris", "Blanc" };

            var voitures = Builder<Voiture>.CreateListOfSize(200)
              .All()
                .With(v => v.Id = 0)
                .With(v => v.ModeleId = 0)
                .With(v => v.Annee = yearGenerator.Next(DateTime.Now.Year - 12, DateTime.Now.Year))
                .With(v => v.PrixJournalier = priceGenerator.Next(60, 140))
                .With(v => v.Modele = Pick<Modele>.RandomItemFrom(modeles))
                .With(v => v.Couleur = Pick<string>.RandomItemFrom(couleurs))
              .Build();
            context.Voitures.AddRange(voitures);
            context.SaveChanges();



            //List<Location> locations = new List<Location>()
            //{
            //    new Location() {
            //        Id = 1,
            //        DateLocation = new DateTime(2015, 12, 31),
            //        DureeEnJours = 10,
            //        ClientId=context.ApplicationUser.Take( ),
            //        VoitureId=2
            //    }

            //};

          
        }

    }
}
