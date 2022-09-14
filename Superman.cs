using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark2
{
    class Superman : SuperHeroe, IVolador
    {
        private int expriencia = 0;

        public void Volador()
        {
            expriencia += 3;
            Console.WriteLine("Estoy volando como un campeón");
        }
    }
}
