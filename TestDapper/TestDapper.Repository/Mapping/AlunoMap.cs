using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDapper.Entity.Entities;

namespace TestDapper.Repository.Mapping
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> entity)
        {
            entity.ToTable("tb_alunos");

            entity.HasKey(a => a.Id);

            entity.Property(a => a.Id)
                  .HasColumnName("id");

            entity.Property(a => a.Name)
                  .HasColumnName("nome")
                  .HasMaxLength(10);

        }
    }
}
