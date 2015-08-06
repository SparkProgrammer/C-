using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab___AbstractAnimalKingdom;

namespace Tutorial7
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalsArray = new Animal[5];

            animalsArray[0] = new Lion();
            animalsArray[1] = new Elephant();
            animalsArray[2] = new Lion();
            animalsArray[3] = new Elephant();
            animalsArray[4] = new Lion();

            foreach (Animal animal in animalsArray) 
            {
                animal.Move();
                animal.Sleep();
            } 



        }
    }
}
