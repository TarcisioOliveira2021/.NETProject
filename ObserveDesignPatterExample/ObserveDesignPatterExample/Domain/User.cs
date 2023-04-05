using ObserveDesignPatterExample.Aplication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesignPatterExample.Domain
{
    public class User : IObserver
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public void Update(object obj)
        {
            var tweet = (Tweet)obj;

            Console.WriteLine($"User: {this.Username} - Tweet: {tweet.Text}");
        }
    }
}
