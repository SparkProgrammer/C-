using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial3
{
    class Grades
    {
        private int[] gradesList;

        public Grades()
        {
            gradesList = new int[10];
        }

        public float CalculateAverage()
        {
            float totalCount = 0.0f;
            for (int i = 0; i < gradesList.Length; ++i)
            {
                totalCount += gradesList[i];
            }
            return totalCount / gradesList.Length;
        }

        public void GetGradesFromUser()
        {
            for (int i = 0; i < gradesList.Length; ++i)
            {
                Console.Write("Enter a Grade: ");
                gradesList[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public int GetLowestGrade() 
        {
            /*
            Array.Sort(gradesList);
            return gradesList[0];
             */
            int lowestGrade = gradesList[0];

            foreach (int x in gradesList)
            {
                if (x < lowestGrade)
                {
                    lowestGrade = x;
                }
            }
            return lowestGrade;
        }

        public int GetHighestGrade()
        {
            Array.Sort(gradesList);
            return gradesList[gradesList.Length-1];
        }   
  
    }
}
