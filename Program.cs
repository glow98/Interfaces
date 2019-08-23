using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ave Paloma = new Ave("Paloma");
            Ave Cotorro = new Ave("Cotorro");
            Program main = new Program();
            main.imprimir(Paloma);
            main.imprimir(Cotorro);
            Console.ReadKey();
        }
        public void imprimir(Ave ave)
        {
            Console.WriteLine("Soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
            Console.WriteLine("Puedo");
            ave.Volar();
            Console.WriteLine("Y tambien puedo");
            ave.Comer();
        }
    }
}
