using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01.Models.Interfaces;

namespace Exercise01.Models.Interfaces
{
    public class Teacher : User,ITeacher
    {
       
     
            public string Subject { get; set; }

            public override void PrintUser()
            {
                base.PrintUser();
                Console.WriteLine($"Subject: {Subject}");
            }
        

    }
}
