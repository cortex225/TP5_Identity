using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP5_Identity.Models;

namespace TP5_Identity.Data.Configuration
{
    public class AbonnementsConfiguration : IEntityTypeConfiguration<Abonnement>
    {
        public void Configure(EntityTypeBuilder<Abonnement> builder)
        {
            builder.HasData(
                new Abonnement() 
                {
                    Id = 1,
                    Type = "Regulier",
                    PrixMensuel = 0,
                    RabaisPourcentage = 0
                },
                 new Abonnement()
                 {
                     Id = 2,
                     Type = "Argent",
                     PrixMensuel = 50,
                     RabaisPourcentage = 10
                 },
                  new Abonnement()
                  {
                      Id = 3,
                      Type = "Or",
                      PrixMensuel = 100,
                      RabaisPourcentage = 15
                  }
            );
        }

      
    }
}