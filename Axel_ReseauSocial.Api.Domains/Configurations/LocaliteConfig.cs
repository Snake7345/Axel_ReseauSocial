using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Configurations
{
    internal class LocaliteConfig : IEntityTypeConfiguration<Localite>
    {
        public void Configure(EntityTypeBuilder<Localite> builder)
        {
            builder.ToTable("Localite");

            builder.HasKey(l => l.IdLocalite);

            builder.Property(r => r.IdLocalite)
                .UseIdentityColumn();

            builder.Property(l => l.Ville)
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
        }
    }
}
