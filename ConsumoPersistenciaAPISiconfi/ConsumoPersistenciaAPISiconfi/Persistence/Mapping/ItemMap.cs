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
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> entity)
        {
            entity.ToTable("tb_items");
            entity.HasKey(e => e.esfera);

        }
    }
}
