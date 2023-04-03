using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models.Interfaces
{
    public class Student : User,IStudent
    {
        public List<int> Grades { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine($"Grades: {string.Join(", ", Grades)}");
        }
    }
}
