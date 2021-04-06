using System;
using System.Collections.Generic;

namespace _1290._Convert_Binary_Number_to_Linked_List
{
    class Program
    {

        public class ListNode
        {
            public int val; // field
            public ListNode next; // field
            public ListNode(int val = 0, ListNode next = null)
            { // method that is placing the value into a listnode
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
            ListNode nodeZero = new ListNode(1);
            ListNode nodeOne = new ListNode(0);
            ListNode nodeTwo = new ListNode(1);
           
            



            ListNode list1 = nodeZero;
            list1.next = nodeOne;
            nodeOne.next = nodeTwo;
            
            

            GetDecimalValue(list1);
        }

        public static int GetDecimalValue(ListNode head)
        {


            List<int> convertListNodetoList = new List<int>();
            // add val to the list ... pull the values until i get to a null
            ListNode runner = head;

            // loop
            while (runner != null) // first linked list value
            {
                convertListNodetoList.Add(runner.val);
                runner = runner.next;
            }




            //compare


            // initialize 
            int[] getBaseValue = convertListNodetoList.ToArray(); // is this allowed ... 
            int sum = 0;
            int n = 0;
            // [101]
            //loop      [101001] ==             100101
            for (int i = getBaseValue.Length - 1; i >= 0; i--) // I want to grab the last index and place it into the first base "space"
            {
                if (getBaseValue[i] == 1)
                {

                    sum += (int)Math.Pow(2, n);     // i want to track what space I am on will going through the iteration 
                }
                n++;
            }

            return sum;
        }
    }
}
