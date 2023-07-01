using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Node<T>
    {
        public T? Data { get; }

        public Node<T?> Next { get; set; }

        public Node<T?> Prev { get; set; }

        public Node(T? value)
        {
            Data = value;
            Next = null;
            Prev = null;
        }
    }
}
