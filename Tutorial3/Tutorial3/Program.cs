using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            String dividerLine = new String('-', 38);

            System.Console.OutputEncoding = Encoding.UTF8;

            System.Console.WriteLine("{0, -8} {1,14} {2, -10}", "Emp ID", "Salary", "Comission");
            System.Console.WriteLine(dividerLine);

            for (int count = 1; count <= 5; ++count)
            {
                System.Console.Write("Enter the Emp ID: ");
                int emp_id = Convert.ToInt32(System.Console.ReadLine());

                System.Console.Write("Enter the Salary: ");
                decimal salary = Convert.ToDecimal(System.Console.ReadLine());

                System.Console.Write("Enter the Commission: ");
                decimal commission = Convert.ToDecimal(System.Console.ReadLine());

                System.Console.WriteLine("{0, -8}   {1, 14:F2}   {2, 10:F}", emp_id, salary, commission);
                
             }*/
                
                Grades a = new Grades();

                a.GetGradesFromUser();
                float average = a.CalculateAverage();
                Console.WriteLine("Average: {0}", average);

                int lowestGrade = a.GetLowestGrade();
                Console.WriteLine("Lowest Grade: {0}", lowestGrade);

                int highestGrade = a.GetHighestGrade();
                Console.WriteLine("Highest Grade: {0}", highestGrade);
    
        }
    }
}
