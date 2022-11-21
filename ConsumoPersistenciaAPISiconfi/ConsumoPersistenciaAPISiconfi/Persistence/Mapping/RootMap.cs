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
   
    public class RootMap : IEntityTypeConfiguration<Root>
    {
        public void Configure(EntityTypeBuilder<Root> entity)
        {
            entity.ToTable("tb_anexos_relatorios");
            entity.HasKey(e => e.id);

            entity.Property(e => e.items)
                .HasColumnName("item");

            entity.Property(e => e.links)
                .HasColumnName("link");

            //Contem um relacionamento 1 root tem : N Items e Links.
            entity.HasMany(e => e.items)
                .WithOne(e => e.root)
                .HasForeignKey(s => s.rootId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(e => e.links)
                .WithOne(e => e.root)
                .HasForeignKey(s => s.rootId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
   
}
