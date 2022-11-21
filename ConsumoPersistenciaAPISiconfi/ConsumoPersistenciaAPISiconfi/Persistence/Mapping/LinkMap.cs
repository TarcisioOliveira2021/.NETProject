using ConsumoPersistenciaAPISiconfi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoPersistenciaAPISiconfi.Persistence.Mapping
{
    public class LinkMap : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> entity)
        {
            entity.ToTable("tb_links");
            entity.Property(e => e.href)
                .HasColumnName("url");

            entity.Property(e => e.rel)
                .HasColumnName("url");

        }
    }
}
