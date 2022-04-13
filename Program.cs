using System;

namespace DataStructure
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //var strDup = new string[] { "Csharpstar", "Google", "Yahoo", "CNN" };
            //foreach (var item in strDup)
            //{
            //    CallRemoveDuplicate(item);
            //}

            var anagramString = new[] { ("Silent", "Listen"), ("post", "opts"), ("abc","acb"),("abb","aab") };
            foreach (var item in anagramString)
            {
                var res = new DuplicateCharRemoval().IsAnagram(item.Item1, item.Item2);
                Console.WriteLine($"IsAnagram {res}"); 
            }


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
            CallBinarySearch();

            int a = 1;
            int b = 2;
            (a, b) = (b, a);
            Console.WriteLine($"Value{a} \n {b} ");
            int[] input = new int[] {3,2,4,6,1 };
            MergeSort.SortMerge(input,0, input.Length - 1);

        }

        public static void CallBinarySearch()
        {
            BinarySearch nums = new BinarySearch();
            nums.Insert(50);
            nums.Insert(54);
            nums.Insert(17);
            nums.Insert(23);
            nums.Insert(12);
            nums.Insert(19);
            nums.Insert(9);
            nums.Insert(14);
            nums.Insert(67);
            nums.Insert(76);
            nums.Insert(72);

            nums.Preorder(nums.ReturnRoot());
        }


        public static void CallRemoveDuplicate(string key)
        {

            DuplicateCharRemoval duplicate = new DuplicateCharRemoval();
            Console.WriteLine($"string after removing duplicate {duplicate.RemoveDuplicate(key)}");
        }
       

    }
}
