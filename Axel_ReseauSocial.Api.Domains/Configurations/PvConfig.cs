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
    internal class PvConfig : IEntityTypeConfiguration<Pv>
    {
        public void Configure(EntityTypeBuilder<Pv> builder)
        {
            builder.ToTable("Pv");

            builder.HasKey(p => p.IdPv);

            builder.Property(p => p.IdPv)
                .HasDefaultValueSql("NEWSEQUENTIALID()");
            builder.HasOne(p => p.Destinataire)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Destinateur)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
