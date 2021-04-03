using System;

namespace _1491._Avg_Salary_without_Max_and_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a sample array
            int[] salary = { 4000, 3000, 1000, 2000 };
            avg(salary);

        }
        public static double avg(int[] avgsalary)
        {
            // array sort allow you to put the min in the front and the max in the back
            Array.Sort(avgsalary);
            //create a double to ease the return and also to store the total amounts
            double temptotalofSalary = 0;
            //not able to divide by avgsalary.Length ... need a counter
            double counter = 0;
            // for loop starts at 1 and ends at array's end index -1 ... remove teh max and min
            for (int i = 1; i < avgsalary.Length - 1; i++)
            {
                counter++;
                temptotalofSalary += avgsalary[i];
            }
            // get the average and return
            double avgWithoutMaxandMin = temptotalofSalary / counter;
            return avgWithoutMaxandMin;
        }
    }
}
