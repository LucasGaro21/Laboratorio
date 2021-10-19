using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprimibleDesafioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();
            Documento documento = new Documento();
            Foto foto = new Foto();
            Contrato contrato = new Contrato();

            impresora.AgregarImprimible(documento);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(contrato);

            impresora.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
