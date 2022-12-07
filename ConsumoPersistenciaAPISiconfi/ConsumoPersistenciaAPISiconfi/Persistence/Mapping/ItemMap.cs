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
    //Classe ou arquivo de configuração de entidades
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> entity)
        {   
            //Conceito de FluentAPI -- Para configurar os comportamentos das entidades.
            entity.ToTable("tb_items");
            entity.Property(i => i.esfera)
                .HasColumnName("esfera")
                .HasMaxLength(10);

            entity.Property(i => i.anexo)
                .HasColumnName("anexo")
                .HasMaxLength(100);

            entity.Property(i => i.demonstrativo)
                .HasColumnName("demonstrativo")
                .HasMaxLength(100);

            
        }
    }
}
