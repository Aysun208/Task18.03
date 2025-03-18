using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysunClass
{
   public class Bird : Animal
    {
        public bool CanSwim = false;

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
