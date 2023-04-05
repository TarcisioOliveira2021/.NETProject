using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesignPatterExample.Domain
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Like { get; set; }
        public int Share { get; set; }
    }
}
