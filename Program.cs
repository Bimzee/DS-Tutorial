using System;

namespace DataStructure
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //var n = new SimpleLikedList();
            //n.CreateAndPrint3Nodes();

            /*
            var n = new LinkedListWithAdd<int>();
            n.Add(1);
            n.Add(2);
            n.Add(3);
            n.Add(4);
            Console.WriteLine($"LinkedList count is {n.Count}");
            //n.Print();

            n.Remove(3);
            n.Print();
            //LinkedListWithAdd<int>.Print(n);
            */

            int a = 1;
            int b = 2;
            (a, b) = (b, a);
            Console.WriteLine($"Value{a} \n {b} ");
            int[] input = new int[] {3,2,4,6,1 };
            MergeSort.SortMerge(input,0, input.Length - 1);

        }

       

    }
}
