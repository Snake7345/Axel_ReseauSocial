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
    internal class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.HasKey(r => r.IdRole);

            builder.Property(r => r.IdRole)
                .UseIdentityColumn();

            builder.Property(r => r.Denomination)
                .IsRequired()
                .HasColumnType("NVARCHAR(50)");

            builder.HasData(new Role() { IdRole = 1, Denomination = "Admin" });
            builder.HasData(new Role() { IdRole = 2, Denomination = "User" });
        }
    }
}
