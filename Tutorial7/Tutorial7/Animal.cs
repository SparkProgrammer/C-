using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___AbstractAnimalKingdom
{
    abstract class Animal
    {
        private int age;
        private double heightInFeet;
        private double weightInPounds;
        private String name;

        #region Animal Properties
        /// <summary>
        /// The Animal's Age
        /// </summary>
        public int Age
        {
            set
            {
                if(value >= 0)
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }

        /// <summary>
        /// The Animal's Height in Feet
        /// </summary>
        public double HeightInFeet
        {
            set
            {
                if(value >= 0.0)
                {
                    heightInFeet = value;
                }
            }
            get
            {
                return heightInFeet;
            }
        }

        /// <summary>
        /// The Animal's Weight in Pounds
        /// </summary>
        public double WeightInPounds
        {
            set
            {
                if(value >= 0.0)
                {
                    weightInPounds = value;
                }
            }
            get
            {
                return weightInPounds;
            }
        }

        /// <summary>
        /// The Animal's Name
        /// </summary>
        public String Name
        {
            set
            {
                if(value.Length > 0)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        #endregion

        /// <summary>
        /// Constructs an Animal object
        /// </summary>
        /// <param name="age">The age (0, by default)</param>
        /// <param name="heightInFeet">The height in feet (0, by default)</param>
        /// <param name="weightInPounds">The weight in pounds (0, by default)</param>
        /// <param name="name">The animal's name ('My Pet', by default)</param>
        public Animal(int age = 0, double heightInFeet = 0.0, 
                double weightInPounds = 0.0, String name = "My Pet")
        {
            //Be sure to point out that the Constructor can use the properties - thus avoiding
            //duplicate validation code
            Age = age;
            HeightInFeet = heightInFeet;
            WeightInPounds = weightInPounds;
            Name = name;
        }

        /// <summary>
        /// Move the animal
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// Make the animal sleep
        /// </summary>
        public virtual void Sleep()
        {
            Console.WriteLine("{0} is sleeping now...", Name);
        }
    }
}
