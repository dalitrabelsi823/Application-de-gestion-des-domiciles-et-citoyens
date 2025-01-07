using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Infrastructure.Configurations
{
    internal class BatimentConfiguration : IEntityTypeConfiguration<Batiment>
    {


        public void Configure(EntityTypeBuilder<Batiment> builder)
        {
            builder.HasMany(b => b.MyDomiciles)
                .WithOne(d => d.MyBatiment)
                .HasForeignKey(d => d.BatimentFK);
        }
    }
}
