using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample.Ramen
{
    public abstract class RamenTemplate
    {
        public void Cooking()
        {
            AddNoodle();
            AddBroth();
            AddMeat();
            AddVedgetables();

            if (AddEggDecision()) { AddEgg(); }
            if (AddSauseDecision()) { AddSause(); }
        }

        public abstract void AddNoodle();
        public abstract void AddSause();
        public abstract void AddMeat();
        public abstract void AddEgg();
        public void AddVedgetables() => Console.WriteLine("Added Vedgetables");
        public void AddBroth() => Console.WriteLine("Added Broth");
        public virtual bool AddSauseDecision() => true;
        public virtual bool AddEggDecision() => true;
    }
}
