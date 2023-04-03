using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models.Interfaces
{
    public interface IStudent
    {
        List<int> Grades { get; set; }
        void PrintUser();

    }
}
