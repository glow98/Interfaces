﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter3
{
    class AvePropiedades:IAve
    {
        public int Patas = 2;
        public int Alas = 2;
        public int Cola = 1;
        public string Nombre { get; private set; }

        public AvePropiedades(String NAve)
        {
            this.Nombre = NAve;
        }

        public void Volar()
        {
            Console.WriteLine("Volar");
        }

        public void Comer()
        {
            Console.WriteLine("Comer");
        }
    }
}
