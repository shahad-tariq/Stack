using System.Collections.Generic;

namespace Stack
{
    public static class LinkedListExtension
    {

        public static LinkedList<T> Reverse<T>(this LinkedList<T> linked)
        {
            
            List<T> list = new List<T>(linked);
            list.Reverse();

            linked = new LinkedList<T>(list);


            return linked;
        }

        public static LinkedList<T> Merge<T>(this LinkedList<T> linked1, LinkedList<T> linked2)
        {

            HashSet<T> hash1 = new HashSet<T>(linked1);
            HashSet<T> hash2 = new HashSet<T>(linked2);

            hash1.UnionWith(hash2);

            LinkedList<T> mergeLinked = new LinkedList<T>(hash1);


            return mergeLinked;
        }

        public static bool IsSubset<T>(this LinkedList<T> linked1, LinkedList<T> linked2)
        {

            HashSet<T> hash1 = new HashSet<T>(linked1);
            HashSet<T> hash2 = new HashSet<T>(linked2);

            return hash1.IsSubsetOf(hash2);
        }


    }
}
