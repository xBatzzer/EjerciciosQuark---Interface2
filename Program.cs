using System;

namespace EjerciciosQuark2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boing747 boing = new Boing747();
            Superman superman = new Superman();
            TorreDeControl tdc = new TorreDeControl();

            tdc.AgregarVolador(pato);
            tdc.AgregarVolador(superman);
            tdc.AgregarVolador(boing);

            tdc.VuelenTodos();

            Console.ReadKey();
        }
    }
}
