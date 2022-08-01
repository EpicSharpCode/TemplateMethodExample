using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample.Ramen
{
    internal class WheatRamen : RamenTemplate
    {
        public override void AddEgg()
        {
            Console.WriteLine("Added 2 eggs slices");
        }

        public override void AddMeat()
        {
            Console.WriteLine("Added 5 chiken meat slices");
        }

        public override void AddNoodle()
        {
            Console.WriteLine("Added wheat noodle");
        }

        public override void AddSause()
        {
            Console.WriteLine("Added sweet and sour sauce");
        }

        public override bool AddSauseDecision()
        {
            Console.Write("You want add sause? (y/n): ");
            var userInput = Console.ReadLine();

            if (userInput.ToLower() == "y") { return true; }
            return false;
        }
    }
}
