using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark2
{
    class Pato : Animal, IVolador
    {
        private int energia = 5;

        public void Volador()
        {
            energia -= 1;
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
        }
    }
}
