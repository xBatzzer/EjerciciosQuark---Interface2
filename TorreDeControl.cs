using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosQuark2
{
    class TorreDeControl
    {
        public List<IVolador> voladores = new List<IVolador>();

        public void VuelenTodos()
        {
            foreach (IVolador v in voladores)
            {
                v.Volador();
            }
        }

        public void AgregarVolador(IVolador volador)
        {
            voladores.Add(volador);
        }
    }
}
