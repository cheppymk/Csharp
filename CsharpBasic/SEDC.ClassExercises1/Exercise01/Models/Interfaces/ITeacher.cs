﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models.Interfaces
{
    public interface ITeacher
    {
        string Subject { get; set; }
        void PrintUser();

    }
}
