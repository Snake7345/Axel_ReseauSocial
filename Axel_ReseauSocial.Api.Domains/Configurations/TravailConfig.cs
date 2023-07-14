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
    internal class TravailConfig : IEntityTypeConfiguration<Travail>
    {
        public void Configure(EntityTypeBuilder<Travail> builder)
        {
            builder.ToTable("Travail");

            builder.HasKey(t => t.IdTravail);

            builder.Property(t => t.IdTravail)
                .UseIdentityColumn();

            builder.Property(t => t.Denomination)
                .IsRequired()
                .HasColumnType("NVARCHAR(255)");
        }
    }
}
