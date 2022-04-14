using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNoises
{
    internal class Dog : AnimalNoise
    {
        public string getNoise()
        {
            return "Dog does woof woof";
        }
    }
}
