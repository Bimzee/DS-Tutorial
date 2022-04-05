using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    public class SimpleLikedList
    {
        public void CreateAndPrint3Nodes()
        {
            Node a1 = new Node() { Value = 1 };

            Node a2 = new Node() { Value = 2 };
            Node a3 = new Node() { Value = 3 };
            a1.Next = a2;
            a2.Next = a3;
            Console.WriteLine("Hello World!");
            Print(a1);
        }

        private static void Print(Node node)
        {
            while (node != null)
            {
                Console.WriteLine($"Value ={node.Value}");
                node = node.Next;
            }
        }
    }
}
