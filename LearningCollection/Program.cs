using System;
using System.Collections.Generic;

namespace LearningCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoListDemo();
        }

        private static void DoStackDemo()
        {
            //creating stack
            Stack<String> stack = new Stack<string>();
            //Push element
            stack.Push("luffy");
            stack.Push("Zoro");
            stack.Push("Nami");
            stack.Push("Usopp");
            stack.Push("Sanji");
            stack.Push("Chopper");
            stack.Push("Robin");
            stack.Push("Franky");
            stack.Push("Brook");
            //Iterating in stack
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }
        }
        private static void DoListDemo()
        {
            Console.WriteLine("In List Demo");
            //creating list
            List<string> list = new List<string>();
            //Add element
            list.Add("Luffy");
            list.Add("Zoro");
            list.Add("Nami");
            list.Add("Usopp");
            list.Add("Sanji");
            list.Add("Chopper");
            list.Add("Robin");
            list.Add("Franky");
            list.Add("Brook");
            //Iterating
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
