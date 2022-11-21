using ConsumoPersistenciaAPISiconfi.Entities;
using ConsumoPersistenciaAPISiconfi.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoPersistenciaAPISiconfi.Persistence.Context
{
    //Representa o contexto de dados da aplicação. ( Banco de dados )
    public class EfCoreDbContext : DbContext
    {

        //Construtor
        public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options) : base(options) { }

        //DbSet -- Tabelas.
        public DbSet<Link> links { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Root> Roots { get; set; }


        //Método responsavél por aplicar alterações nas tabelas do banco de dados.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Desacoplando a responsabilidade de criação das propriedades da classe contexto.
            modelBuilder.ApplyConfiguration(new RootMap());
            modelBuilder.ApplyConfiguration(new ItemMap());
        }
    }
}
