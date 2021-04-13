using System;
using System.Collections.Generic;

namespace _20._Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = validParentheses("{[()]}");
            
            Console.WriteLine(result);
        }

        public static bool validParentheses(string input)
        {
            //we are wanting to create a stack 
            //the stack will verify if the string input is valid or not ... mean the '(' has its opposite ')' where each value you cancel out
            //if true the stack count should be 0 ... if not then false
            //the first char will push onto the stack ... iterate through '{' '[' '('
            //check the next index to determine if it meets the requirements needed ')' ']' '}' ... stack pop off
            //count use counter or stack.count

            Stack<char> checkParenthese = new Stack<char>();
            char[] eachCharacter = input.ToCharArray();
            if (input.Length <= 1)
            {
                return false;
            }
            for (int i = 0; i < eachCharacter.Length; i++)
            {
                if (eachCharacter[i] == '{' || eachCharacter[i] == '[' || eachCharacter[i] == '(')
                {
                    checkParenthese.Push(eachCharacter[i]);
                }
                else if (eachCharacter[i] == '}' && checkParenthese.Peek() == '{')
                {
                    checkParenthese.Pop();
                }
                else if (eachCharacter[i] == ']' && checkParenthese.Peek() == '[')
                {
                    checkParenthese.Pop();
                }
                else if (eachCharacter[i] == ')' && checkParenthese.Peek() == '(')
                {
                    checkParenthese.Pop();
                }
                else
                {
                    checkParenthese.Push(eachCharacter[i]);
                }
            }
            if(checkParenthese.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
