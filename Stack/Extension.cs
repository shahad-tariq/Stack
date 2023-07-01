using System.Collections.Generic;

namespace Stack
{
    public static class Extension
    {
        public static LinkedList<T> Reverse<T>(this LinkedList<T> linked)
        {
            LinkedListNode<T> currentNode = linked.First;


            while (currentNode != null)
            {
                LinkedListNode<T> next = currentNode.Next;
                linked.Remove(currentNode);
                linked.AddFirst(currentNode);
                currentNode = next;
            }

            return linked;
        }

       

    }
}
