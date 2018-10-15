using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Objetos_Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso p1 = new Peso(1000, "lb");
            p1.GetLibras();
            p1.GetLingotes();
            p1.GetPeso("k");




            Console.ReadLine();
        }
    }
}
