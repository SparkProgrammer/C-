using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle earth = new Circle();
            earth.Diameter = 55.5;

            earth.Radius = 55.0;

            earth.ToString();

            Console.WriteLine(earth);

            Circle[] elementaryCircles = new Circle[5];

            int index = 0;

            while (index < elementaryCircles.Length)
            {
                Console.WriteLine("Please enter a new radius: ");
                elementaryCircles[index] = new Circle();
                elementaryCircles[index].Radius = Convert.ToDouble(Console.ReadLine());

                ++index;
            }

            foreach(Circle circle in elementaryCircles)
            {
                Console.WriteLine(circle);
            }

        }
    }
}
