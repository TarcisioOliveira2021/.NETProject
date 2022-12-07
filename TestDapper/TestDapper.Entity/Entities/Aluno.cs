using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDapper.Entity.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Aluno( int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
