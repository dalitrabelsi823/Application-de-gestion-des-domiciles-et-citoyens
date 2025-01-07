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
    public class DomiciliationConfiguration : IEntityTypeConfiguration<Domicilaition>
    {
        public void Configure(EntityTypeBuilder<Domicilaition> builder)
        {
            builder.HasKey(d => new { d.CitoyenCode, d.DomicileCode });

            builder.HasOne(d => d.MyDomicile)
                .WithMany(d => d.MyDomiciliations)
                .HasForeignKey(d => d.DomicileCode);

            builder.HasOne(d => d.MyCitoyen)
                .WithMany(d => d.MyDomiciliations)
                .HasForeignKey(d => d.CitoyenCode);
        }
    }
}
