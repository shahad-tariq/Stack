using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(new LinkedListNode<int>(10));
            stack.Push(new LinkedListNode<int>(20));
            stack.Push(new LinkedListNode<int>(30));
            stack.Push(new LinkedListNode<int>(70));
            stack.Push(new LinkedListNode<int>(70));
            stack.Push(new LinkedListNode<int>(80));
            stack.Push(new LinkedListNode<int>(80));
            stack.Push(new LinkedListNode<int>(80));
            stack.Push(new LinkedListNode<int>(40));
            stack.Push(new LinkedListNode<int>(50));
            stack.Push(new LinkedListNode<int>(90));
            stack.Push(new LinkedListNode<int>(90));
            stack.Push(new LinkedListNode<int>(90));
            stack.Push(new LinkedListNode<int>(100));


            stack.Pop();
            stack.Pop();

            Console.WriteLine(stack.IsEmpty);
            stack.Display();

            Console.WriteLine();
            stack.Reverse();
            stack.Display();


            Console.WriteLine();
            Console.WriteLine("Max: ");
            Console.WriteLine(stack.MaxElement());


            Console.WriteLine();
            Console.WriteLine("Min: ");
            Console.WriteLine(stack.MinElement());

            //Console.WriteLine("Remove All: ");
            //stack.RemoveAll();
            //stack.Display();

            Console.WriteLine();
            Console.WriteLine("Remove Specific Element: ");
            stack.PopSpecificElement(80);
            stack.Display();

            Console.WriteLine();
            Console.WriteLine("Count Elements: " + stack.Count);

            Console.WriteLine();
            Console.WriteLine("Count Specific Elements: " + stack.GetCountSpecificElement(90));


            Console.WriteLine();
            Console.WriteLine("Is Element Exist: " + stack.IsElementExist(200));
            Console.WriteLine("Is Element Exist: " + stack.IsElementExist(70));

            Console.WriteLine();
            Console.WriteLine("Remove Duplicate: ");
            stack.RemoveDuplicate();
            stack.Display();

            Console.WriteLine();
            Console.WriteLine("Top & Bottom Element: ");
            Console.WriteLine(stack.GetTopAndBottomElement());


            Console.WriteLine();
            Console.WriteLine("Swap Top Two Element: ");
            stack.SwapTopTwoElement();
            stack.Display();

            Console.WriteLine();
            Console.WriteLine("Get Nth Element: ");
            Console.WriteLine(stack.GetNthElement(1));
        }
    }
}
