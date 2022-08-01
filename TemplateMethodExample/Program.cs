using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodExample.Ramen;

namespace TemplateMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RamenTemplate wheatRamen = new WheatRamen();
            RamenTemplate sobaRamen = new SobaRamen();

            Console.WriteLine("Cooking Wheat Ramen");
            wheatRamen.Cooking();
            Console.WriteLine();
            Console.WriteLine("Cooking Soba Ramen");
            sobaRamen.Cooking();

            Console.ReadLine();

        }
    }
}
