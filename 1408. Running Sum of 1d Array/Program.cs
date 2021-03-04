using System;

namespace _1408._Running_Sum_of_1d_Array
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            int sum = 0;  
            int[] nums = { 1, 2, 3, 4, 5 }; 
            int[] sumResult = new int[nums.Length]; 
            for (int i = 0; i < nums.Length; i++) 
            {
                sum += nums[i]; 
                
                sumResult[i] = sum;
            }
            foreach(var item in sumResult) 
            {  
                Console.WriteLine(item.ToString());
            }
        }
    }
}
