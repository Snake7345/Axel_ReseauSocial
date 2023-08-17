using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Configurations
{
    internal class AmitieConfig : IEntityTypeConfiguration<Amitie>
    {
        public void Configure(EntityTypeBuilder<Amitie> builder)
        {
            builder.ToTable("Amitie");

            builder.HasKey(a => a.IdAmitie);

            builder.Property(a => a.IdAmitie)
                .HasDefaultValueSql("NEWSEQUENTIALID()");

            builder.Property(a => a.Attente)
                .IsRequired()
                .HasColumnType("BIT")
                .HasDefaultValue(true);

            builder.HasOne(a => a.Destinataire)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Destinateur)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
