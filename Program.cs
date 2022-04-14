using System;

namespace AnimalNoises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalNoise[] animals= new AnimalNoise[2];
            animals[0] = new Dog();
            animals[1] = new Cow();

            for(int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].getNoise());
            }
        }
       
    }
}
