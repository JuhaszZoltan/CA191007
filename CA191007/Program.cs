using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191007
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>
            {
                "borsó", "lovasszekér", "kréta"
            };

            foreach (var i in lista)
            {
                Console.Write(i);
            }

            Console.ReadKey();
        }
    }
}
