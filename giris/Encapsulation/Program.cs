﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.setisim("Sevde");
            ogrenci1.getisim();
            Console.ReadLine();
        }
    }
}
