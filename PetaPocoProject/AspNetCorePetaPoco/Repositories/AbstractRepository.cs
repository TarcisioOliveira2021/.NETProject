using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using PetaPoco;
using PetaPoco.Providers;

namespace AspNetCorePetaPoco.Repositories
{
    public abstract class AbstractRepository<T>
    {
        private string _connectionString;
        private IDatabase _db;
        protected IDatabase Db => _db;

        //construtor da classe
        public AbstractRepository(IConfiguration configuration){
            _connectionString = configuration.GetValue<string>("DbInfo:MyConnectionString");

            _db = DatabaseConfiguration.Build()
                  .UsingConnectionString(_connectionString)
                  .UsingProvider<MySqlDatabaseProvider>()
                  .Create();

            _db.Execute(LoadTexResource("mysql_init.sql"));    
        }

        public abstract void Add(T item);
        public abstract void Remove(int id);
        public abstract void Update(T item);
        public abstract T FindById(int id);
        public abstract IEnumerable<T> FindAll();

        private string LoadTexResource(string nameResource)
        {
            var path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Scripts", nameResource);
            System.Console.WriteLine(path);
            System.IO.StreamReader r = new System.IO.StreamReader(path);
            string str = r.ReadToEnd();
            r.Close();

            return str;
        }
    }
}