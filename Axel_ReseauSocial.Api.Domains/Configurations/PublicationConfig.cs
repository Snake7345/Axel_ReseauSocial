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
    internal class PublicationConfig : IEntityTypeConfiguration<Publication>
    {
        public void Configure(EntityTypeBuilder<Publication> builder)
        {
            builder.ToTable("Publication");

            builder.HasKey(p => p.IdPublication);

            builder.Property(p => p.IdPublication)
                .HasDefaultValueSql("NEWSEQUENTIALID()");

            builder.HasOne(p => p.Utilisateur)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
