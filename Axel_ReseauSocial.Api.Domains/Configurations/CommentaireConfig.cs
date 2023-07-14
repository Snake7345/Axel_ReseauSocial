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
    internal class CommentaireConfig : IEntityTypeConfiguration<Commentaire>
    {
        public void Configure(EntityTypeBuilder<Commentaire> builder)
        {
            builder.ToTable("Commentaire");

            builder.HasKey(c => c.IdCommentaire);

            builder.Property(c => c.IdCommentaire)
                .HasDefaultValueSql("NEWSEQUENTIALID()");

            builder.HasOne(c => c.Utilisateur)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(u => u.Publication)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
