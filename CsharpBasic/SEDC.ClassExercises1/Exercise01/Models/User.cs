using Exercise01.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Username: {Username}");
        }
    }
}
