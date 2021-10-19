using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprimibleDesafioInterfaces
{
    class Impresora
    {
        List<IImprimible> colaDeImpresion = new List<IImprimible>();
        public void ImprimirTodo()
        {
            foreach (IImprimible i in colaDeImpresion)
            {
                i.Imprimir();
            }

        }

        public void AgregarImprimible(IImprimible unImprimible)
        {
            colaDeImpresion.Add(unImprimible);
        }
    }
}
