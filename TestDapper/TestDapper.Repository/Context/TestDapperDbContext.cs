using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDapper.Entity.Entities;
using TestDapper.Repository.Mapping;

namespace TestDapper.Repository.Context
{
    public class TestDapperDbContext : DbContext
    {
        public TestDapperDbContext(DbContextOptions<TestDapperDbContext> options) : base(options) { }

        public DbSet<Aluno> alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
        }
    }
}
