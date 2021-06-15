using System;
using System.Collections.Generic;

namespace Algorithm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non empty list.
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            // Head node.
            LinkedListNode<int> head = list.First;

            Console.WriteLine("List:");
            foreach (var node in list)
                Console.Write(node + " ");
            Console.WriteLine();

            LinkedListNode<int> current = head;
            int count = 0;
            // Iterate over the list and it's length.
            while(current.Next != null)
            {
                count++;
                current = current.Next;
            }
            // Set current back to head;
            current = head;
            // Get the middle node.
            for(int i = 0; i < count / 2; i++)
                current = current.Next;

            Console.WriteLine("Middle(rounded down) node value: " + current.Value);
        }
    }
}
