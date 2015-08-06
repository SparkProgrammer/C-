/*
    Coded by: Concord Spark Tutor
    Date: July 11, 2015
    Purpose: Demonstrate LINQ to Objects
*/

using System;
using System.Collections.Generic;
using System.Linq; //Be sure to specify that System.Linq is required!
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8___LINQtoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 100, 25, 33, 44, 66, 77, 88, 99 };

            IEnumerable<int> numbersGreater = from number in numbers
                              where number > 50
                              orderby number
                              select number;

            

            foreach (int number in numbersGreater) {
                Console.WriteLine("{0,0:D}", number);
            }

            Console.ReadKey();
        }
    }
}
