using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark2
{
    class Boing747 : Avion, IVolador
    {
        private int horasDeVuelo = 0;

        public void Volador()
        {
            horasDeVuelo += 13;
            Console.WriteLine("Estoy volando como un avion...");
        }
    }
}
