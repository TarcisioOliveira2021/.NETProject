//1 - Jeito de conectar ao banco de dados.
//var db = new PetaPoco.Database("connctionString"); 

//2 - Jeito de conectar ao banco de dados.
using PetaPoco;
using PetaPoco.Providers;

var db = DatabaseConfiguration.Build()
         .UsingConnectionString("minhaConnectionString")
         .UsingProvider<MySqlDatabaseProvider>()
         .UsingDefaultMapper<ConventionMapper>(m => 
         {
            m.InflectTableName = (inflector, s) => inflector.Pluralise(inflector.Underscore(s));
            m.InflectColumnName = (inflector, s) => inflector.Underscore(s);
         }).Create();
         