using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();

            stack1.Push(new LinkedListNode<int>(10));
            stack1.Push(new LinkedListNode<int>(20));
            stack1.Push(new LinkedListNode<int>(30));
            stack1.Push(new LinkedListNode<int>(70));
            stack1.Push(new LinkedListNode<int>(70));
            stack1.Push(new LinkedListNode<int>(80));
            stack1.Push(new LinkedListNode<int>(80));
            stack1.Push(new LinkedListNode<int>(80));
            stack1.Push(new LinkedListNode<int>(40));
            stack1.Push(new LinkedListNode<int>(50));
            stack1.Push(new LinkedListNode<int>(90));
            stack1.Push(new LinkedListNode<int>(90));
            stack1.Push(new LinkedListNode<int>(90));
            stack1.Push(new LinkedListNode<int>(100));


            stack1.Pop();
            stack1.Pop();

            Console.WriteLine(stack1.IsEmpty);
            stack1.Display();

            Console.WriteLine();
            Console.WriteLine("Reverse: ");
            stack1.Reverse();
            stack1.Display();


            Console.WriteLine();
            Console.WriteLine("Max: ");
            Console.WriteLine(stack1.MaxElement());


            Console.WriteLine();
            Console.WriteLine("Min: ");
            Console.WriteLine(stack1.MinElement());

            //Console.WriteLine("Remove All: ");
            //stack.RemoveAll();
            //stack.Display();

            Console.WriteLine();
            Console.WriteLine("Remove Specific Element: ");
            stack1.PopSpecificElement(80);
            stack1.Display();

            Console.WriteLine();
            Console.WriteLine("Count Elements: " + stack1.Count);

            Console.WriteLine();
            Console.WriteLine("Count Specific Elements: " + stack1.GetCountSpecificElement(90));


            Console.WriteLine();
            Console.WriteLine("Is Element Exist: " + stack1.IsElementExist(200));
            Console.WriteLine("Is Element Exist: " + stack1.IsElementExist(70));

            Console.WriteLine();
            Console.WriteLine("Remove Duplicate: ");
            stack1.RemoveDuplicate();
            stack1.Display();

            Console.WriteLine();
            Console.WriteLine("Top & Bottom Element: ");
            Console.WriteLine(stack1.GetTopAndBottomElement());


            Console.WriteLine();
            Console.WriteLine("Swap Top Two Element: ");
            stack1.SwapTopTwoElement();
            stack1.Display();

            Console.WriteLine();
            Console.WriteLine("Get Nth Element: ");
            Console.WriteLine(stack1.GetNthElement(1));


            Console.WriteLine();
            Console.WriteLine("Merged: ");
            Stack<int> stack2 = new Stack<int>();

            stack2.Push(new LinkedListNode<int>(1));
            stack2.Push(new LinkedListNode<int>(2));
            stack2.Push(new LinkedListNode<int>(3));


            Stack<int> mergedStack = new Stack<int>();
            mergedStack.MergeStacks(stack1, stack2);
            mergedStack.Display();


            //Console.WriteLine();
            //Console.WriteLine("IsSubset: ");
            //Console.WriteLine("Is stack2 a subset of stack1? " + stack1.IsSubsetStacks(stack2));

        }
    }
}
