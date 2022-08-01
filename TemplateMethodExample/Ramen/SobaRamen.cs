using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample.Ramen
{
    internal class SobaRamen : RamenTemplate
    {
        public override void AddEgg()
        {
            Console.WriteLine("Added 3 eggs slices");
        }

        public override void AddMeat()
        {
            Console.WriteLine("Added 5 beef meat slices");
        }

        public override void AddNoodle()
        {
            Console.WriteLine("Added buckwheat noodle");
        }

        public override void AddSause()
        {
            Console.WriteLine("Added spicy sauce");
        }


        public override bool AddEggDecision()
        {
            Console.Write("You want add eggs? (y/n): ");
            var userInput = Console.ReadLine();

            if (userInput.ToLower() == "y") { return true; }
            return false;
        }
    }
}
