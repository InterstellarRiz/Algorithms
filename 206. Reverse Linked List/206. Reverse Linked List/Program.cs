using System;

namespace _206._Reverse_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode Zero = new ListNode(1);
            ListNode One = new ListNode(2);
            ListNode Two = new ListNode(3);
            ListNode Three = new ListNode(4);
            ListNode Four = new ListNode(5);
            ListNode startingNode = Zero;
            startingNode.next = One;
            One.next = Two;
            Two.next = Three;
            Three.next = Four;
            ReverseList(startingNode);

            
        }

        public static ListNode ReverseList(ListNode head)
        {
            if(head == null) // if there is a null input
            {
                return null;
            }
            // we want the reverse the linked list 
            // an example of a head is [1,2,3,4,5] , [1,2] ,[]
            // what if it is one value 
            if (head.next == null)
            {
                return head;
            }
            // output would be [5,4,3,2,1] as a node
            // we can iterate until the we find a null value ... this is how we find the end of the linked list



            //initialize
            // do we need a counter
            // we want to use a runner ... yes dont want to manipulate the head ...

            // possible recursion???
             // just in case ... dont know what I am using it for yet
            
            ListNode runner = head;
            ListNode tempNode = null;

            //use pointers...
            // loop
            while (runner.next != null) // runner or runner.next  we want to go through the linked list how to iterate through a linked list
            {   //[1,2,3,4,5]]
                tempNode = runner.next; //[2 ...3 ... 4 ...
                runner.next = tempNode.next; // runner next = 3 ... 4 ...
                tempNode.next = head; //[1 .. 2
                head = tempNode; // [ head = 2... 3... 
            }
            //we want to set the runner AKA the head to the last known valid ListNode ... runner becomes the new head



            // compare not needed

            return head;
            
        }
    }
}

// tried recursion
//ListNode runner = head
//ListNode returnNode = null;

//if (runner.next == null && counter == 0) // we peek into the next value to see if it is null ... it is 
//{
//    returnNode = runner;
//    counter++;
//}
//else if (runner.next == null)
//{
//    runner = runner.next;
//    returnNode.next = ReverseList(runner); // continous loop ...  never reseting runner.next
//}
//// our new ListNode head "runner" will be added to the returnNode
////do I need to add the val???
//else
//{
//    runner = runner.next;
//}return returnNode; //nope
