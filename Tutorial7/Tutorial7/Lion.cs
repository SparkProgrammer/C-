using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab___AbstractAnimalKingdom;

namespace Tutorial7
{
    class Lion : Animal
    {
        /// <summary>
        /// moves Lion
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Lion is moving");
        }

        /// <summary>
        /// Lets Lion Sleep
        /// </summary>
        public override void Sleep()
        {
            Console.WriteLine("Lion is sleeping");
        }
    }
}
