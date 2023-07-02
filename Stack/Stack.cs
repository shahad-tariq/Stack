using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Stack<T>
    {
        private LinkedList<T> stackList = new LinkedList<T>();
        

        //Q1 LIFO
        public void Push(LinkedListNode<T> newNode)
        {
            stackList.AddFirst(newNode);

        }

        //Q1
        public T Pop()
        {
            CheckValidations();

            T elem = stackList.First();
            stackList.RemoveFirst();

            return elem;
        }


        //Q1
        public bool IsEmpty => (stackList.Count <= 0);



        //Q2
        //Q3


        //Q4
        public void Reverse()
        {
            stackList = LinkedListExtension.Reverse(stackList);
        }


        //Q5
        public T MaxElement()
        {
            return stackList.Max();
        }


        //Q6
        public T MinElement()
        {
            return stackList.Min();
        }


        //Q7 
        public void RemoveAll()
        {
            stackList.Clear();
        }


        //Q8
        public void PopSpecificElement(T element)
        {
            stackList.Remove(element);

        }


        //Q9
        public int Count => stackList.Count;



        //Q10
        public int GetCountSpecificElement(T element)
          => stackList.Count(x => (Comparer<T>.Default.Compare(x, element) == 0));


        //Q11
        public bool IsElementExist(T element)
         => stackList.Find(element) != null;


        //Q12
        public void RemoveDuplicate()
        {
            LinkedListNode<T> currentNode = stackList.First;

            while (currentNode != null)
            {
                LinkedListNode<T> next = currentNode.Next;
                if (GetCountSpecificElement(currentNode.Value) > 1)
                {
                    PopSpecificElement(currentNode.Value);
                }

                currentNode = next;
            }

        }


        //Q13
        public string GetTopAndBottomElement()
        {
            return $"The Top Element : {stackList.First.Value} " +
                   $"the Bottom Element : {stackList.Last.Value}";
        }


        //Q14



        //Q15
        public void SwapTopTwoElement()
        {
            CheckValidations();

            LinkedListNode<T> firstElem = stackList.First;
            LinkedListNode<T> secondElem = stackList.First.Next;

            Pop();
            Pop();
            Push(firstElem);
            Push(secondElem);

        }

        //Q16
        public T GetNthElement(int nth)
        {
            return stackList.ElementAtOrDefault(nth-1);
        }


        //Q17
        public void MergeStacks(Stack<T> stack1, Stack<T> stack2)
        {
            stackList = LinkedListExtension.Merge<T>(
                stack1.stackList,
                stack2.stackList);
        }


        //Q18
        public bool IsSubsetStacks(Stack<T> stack2)
        {
            return LinkedListExtension.IsSubset<T>(stackList, stack2.stackList);
        }



        private void CheckValidations()
        {
            if (IsEmpty)
            {
               throw new Exception("Empty...");
            }
        }




        public void Display()
        {
            CheckValidations();

            foreach (var item in stackList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
