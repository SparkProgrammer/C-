using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab___AbstractAnimalKingdom;

namespace Tutorial7
{
    class Elephant : Animal
    {
        /// <summary>
        /// moves Elephant
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Elephant is moving");
        }

        /// <summary>
        /// Lets Elephant sleep
        /// </summary>
        public override void Sleep()
        {
            Console.WriteLine("Elephant is sleeping");
        }
    }
}
