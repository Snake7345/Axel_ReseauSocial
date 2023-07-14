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
    internal class ContenuConfig : IEntityTypeConfiguration<Contenu>
    {
        public void Configure(EntityTypeBuilder<Contenu> builder)
        {
            builder.ToTable("Contenu");

            builder.HasKey(c => c.IdContenu);

            builder.Property(c => c.IdContenu)
                .HasDefaultValueSql("NEWSEQUENTIALID()");

            builder.Property(c => c.Texte)
                .IsRequired()
                .HasColumnType("NVARCHAR(3000)");

            builder.Property(u => u.DateCreation)
                .IsRequired()
                .HasColumnType("DATETIME");

            builder.HasOne(c => c.Commentaire)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Publication)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(c => c.Pv)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
