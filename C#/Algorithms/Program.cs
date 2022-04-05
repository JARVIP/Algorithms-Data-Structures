using Algorithms.Codility;
using Algorithms.GG.LinkedLists;
using Algorithms.Interview;
using Algorithms.Interview._11EsentialQuestions;
using Algorithms.Interview.Array;
using Algorithms.Interview.DictionariesAndHashmaps;
using Algorithms.Interview.DynamicProgramming;
using Algorithms.Interview.GreedyAlgorithms;
using Algorithms.Interview.Miscellaneous;
using Algorithms.Interview.Sorting;
using Algorithms.MasterOfCodingInterview.Algorithms;
using Interview.Algorithms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Algorithms.Extensions;

namespace Algorithms
{
    class Program
    {
        enum color
        {
            red,green,blue
        }
        static void Main(string[] args)
        {
            #region Test
            ///Reverse array Test
            ///int[] n = new int[]{1,2,3,4 };
            ///ReverseArray reverseArray = new ReverseArray(n);
            ///int[] reversed = reverseArray.GetReverseArray();
            ///foreach(var item in reversed){
            ///    Console.Write($"{item}, ");
            ///}
            ///

            /// PalindromeCheck test
            ///PalindromeCheck palindromeCheck = new PalindromeCheck("radar");
            ///Console.WriteLine(palindromeCheck.IsPalindrome());

            /// Reverse Integer test
            ///ReverseInteger reverse = new ReverseInteger(10000);
            ///Console.WriteLine(reverse.Reverse());

            /// Anagram Test
            ///AnagramProblem anagramProblem = new AnagramProblem("test", "sett");
            ///Console.WriteLine(anagramProblem.IsAnagram());

            /// Duplicate array problem Test
            ///DuplicateArrayProblem duplicateArrayProblem = new DuplicateArrayProblem(new int[]{1 ,2 , 3 , 1, 4, 2});
            ///duplicateArrayProblem.FindDuplicates();

            /// Is number Prime
            ///IsPrime isPrime = new IsPrime(169);
            ///isPrime.Check();

            /// OddOccurrencesInArray
            ///OddOccurrencesInArray odd = new OddOccurrencesInArray(new int[] { 9,3,9,3,9,7,9 });
            ///Console.WriteLine(odd.solution());

            /// BubbleSort
            ///BubbleSort bubbleSort = new BubbleSort(new int[] { 1, -5, 0, 2, -1, 10, 9, 100, 56, -34});
            ///bubbleSort.PrintNums();
            ///bubbleSort.Sort();
            ///bubbleSort.PrintNums();

            /// SelectionSort
            ///SelectionSort selectionSort = new SelectionSort(new int[] { 1, -5, 0, 2, -1, 10, 9, 100, 56, -34});
            ///selectionSort.PrintNums();
            ///selectionSort.Sort();
            ///selectionSort.PrintNums();

            /// InsertionSort
            ///InsertionSort insertionSort = new InsertionSort(new int[] { 1, -5, 0, 2, -1, 10, 9, 100, 56, -34 });
            ///insertionSort.PrintNums();
            ///insertionSort.Sort();
            ///insertionSort.PrintNums();

            // QuickSort
            //QuickSort quickSort = new QuickSort(new int[] { 1, -5, 0, 2, -1, 10, 9, 100, 56, -34 });
            //quickSort.PrintNums();
            //quickSort.Sort();
            //quickSort.PrintNums();


            /// MergeSort
            //MergeSort mergeSort = new MergeSort(new int[] { 1, -5, 0, 2, -1, 10, 9, 100, 56, -34 });
            //mergeSort.PrintNums();
            //mergeSort.Sort();
            //mergeSort.PrintNums();


            /// CountingSort
            //CountingSort countingSort = new CountingSort(new int[] { 1, -5, 0, 2, -1, 10, 9, 100, 56, -34 });
            //countingSort.PrintNums();
            //countingSort.Sort();
            //countingSort.PrintNums();

            //Flags flags = new Flags();
            //flags.solution(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 });



            //BinarySearchTree tree = new BinarySearchTree();
            //tree.Insert(3);
            //tree.Insert(10);
            //tree.Insert(11);
            //tree.Insert(2);
            //tree.Insert(-2);
            //tree.Insert(1000);

            //tree.Traverse();
            //tree.Remove(-2);
            //tree.Traverse();



            //Console.WriteLine("max item: "+tree.GetMaxValue());
            //Console.WriteLine("min item: "+tree.GetMinValue());


            //SherlockAndAnagrams anagrams = new SherlockAndAnagrams();

            //int result = anagrams.Solve("ifailuhkqq");


            //CountTriplets triplets = new CountTriplets();

            //long result = triplets.Solve(new List<long> { 5, 25, 125,5,1 }, 5);

            //LeftRotation leftRotation = new LeftRotation();
            //leftRotation.solve(new List<int> { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 }, 4);

            //FraudulentActivityNotifications f = new FraudulentActivityNotifications();
            //f.Solve(new List<int> { 10, 20, 30, 40, 50}, 3);

            //MaxMin maxMin = new MaxMin();
            //maxMin.Solve(3, new List<int> { 1, 2, 3, 4, 10, 20, 30, 40 });

            //LuckBalance luckBalance = new LuckBalance();
            //luckBalance.Solve(3, new List<List<int>> {
            //    new List<int> { 5,1 },
            //    new List<int> { 2,1 },
            //    new List<int> { 1,1 },
            //    new List<int> { 8,1 },
            //    new List<int> { 10,0 },
            //    new List<int> { 5,0 },

            //});

            //FlippingBits flipping = new FlippingBits();
            //flipping.Solve(2147483647);


            //MostFrequentlyOccuringItem mfi = new MostFrequentlyOccuringItem();

            //int result = mfi.Solve(new[] { 1, 3, 1, 3, 2, 1 });

            //CommonElementsInTwoSortedArrays commonEl = new CommonElementsInTwoSortedArrays();

            //var result = commonEl.Solve(new int[] { 1, 3, 4, 6, 7, 9 }, new int[] { 1, 2, 4, 5, 9, 10 });
            //var result2 = commonEl.CommonElements(new int[] { 1, 3, 4, 6, 7, 9 }, new int[] { 1, 2, 4, 5, 9, 10 });

            //IsOneArrayARotationOfAnother isRotation = new IsOneArrayARotationOfAnother();

            //var result = isRotation.Solve(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 4, 5, 6, 7, 1, 2, 3 });

            //NonRepeatingCharacter nonRepeatingCharacter = new NonRepeatingCharacter();

            //var result = nonRepeatingCharacter.Solve("xxyz");

            //AssignNumbersInMinesweeper assign = new AssignNumbersInMinesweeper();

            //var matrix = assign.Solve(new int[2][] { new int[] { 0, 0 }, new int[] { 3, 3 } }, 4, 4);
            //assign.Print(matrix, 4, 4);
            //FindWhereToExpandInMinesweeper find = new FindWhereToExpandInMinesweeper();

            //var solved = find.Solve(matrix, 4, 4, 1, 3);


            //assign.Print(solved, 4, 4);

            //Knapsack ks = new Knapsack(new int[] { 0,1,2,4,2,5 }, new int[] { 0,5,3,5,3,2});
            //int result = ks.Solve(5, 10);


            //LinkedList llist = new LinkedList();
            //GG.LinkedLists.Node new_node;


            //new_node = llist.NewNode(5);
            //llist.SortedInsert(new_node);

            //new_node = llist.NewNode(10);
            //llist.SortedInsert(new_node);

            //new_node = llist.NewNode(7);
            //llist.SortedInsert(new_node);

            //new_node = llist.NewNode(3);
            //llist.SortedInsert(new_node);

            //new_node = llist.NewNode(1);
            //llist.SortedInsert(new_node);

            //new_node = llist.NewNode(9);
            //llist.SortedInsert(new_node);

            //Console.WriteLine("Created Linked List");
            //llist.PrintList();

            #endregion

            //MasterOfCodingInterview.DataStructures.BinarySearchTree tree = new MasterOfCodingInterview.DataStructures.BinarySearchTree();
            //tree.Insert(9);
            //tree.Insert(4);
            //tree.Insert(6);
            //tree.Insert(20);
            //tree.Insert(170);
            //tree.Insert(15);
            //tree.Insert(1);

            //Queue < MasterOfCodingInterview.DataStructures.Node> q = new Queue<MasterOfCodingInterview.DataStructures.Node>();

            //var result =  tree.DFSInOrder();

            //Console.WriteLine(string.Join(", ", result));

            //q.Enqueue(tree.root);
            //while(q.Count > 0)
            //{
            //    var currentNode = q.Dequeue();
            //    Console.WriteLine(currentNode.Value);

            //    if(currentNode.Left != null)
            //    {
            //        q.Enqueue(currentNode.Left);
            //    }
            //    if(currentNode.Right != null)
            //    {
            //        q.Enqueue(currentNode.Right);
            //    }
            //}

            FibonacciDynamicProgramming fib = new FibonacciDynamicProgramming();
            Dictionary<int,int> cache = new Dictionary<int,int>();

            //int result = fib.Solve(2, cache);
            //Console.WriteLine(result);
            //result = fib.Solve(12, cache);
            //Console.WriteLine(result);
            //result = fib.Solve(22, cache);
            //Console.WriteLine(result);



            //FactorialRecursive fac = new FactorialRecursive();

            //Console.WriteLine(fac.SolveDynamic(5, cache));
            //Console.WriteLine(fac.SolveIterative(5));
            //Console.WriteLine(fac.SolveRecursive(5));


            //foreach(var item in cache.Keys)
            //{
            //    Console.WriteLine(cache[item]);
            //}


            //var sss = new MasterOfCodingInterview.Algorithms.BubbleSort();

          

            //var array = new int[400000]; 
            //var rng = new Random();
            //rng.Shuffle(array);


            //Console.WriteLine("SleveN");
            //var  arr = sss.SolveN(array);

            //Console.WriteLine(string.Join(",", arr));


            //Console.WriteLine("Sleve");
            //arr = sss.Solve(array);
            //Console.WriteLine(string.Join(",", arr));




            //var ss = new MasterOfCodingInterview.Algorithms.SelectionSort();

            //int[] arr = new int[] { 6, 4, 2, 1, 5 };
            //ss.Solve(arr);

            //Console.WriteLine(string.Join(",", arr));


            //var inss = new MasterOfCodingInterview.Algorithms.InsertionSort();
            //int[] arr2 = new int[] { 6, 4, 2,1, 5 };
            //inss.Solve(arr2);
            //Console.WriteLine(string.Join(",", arr2));

        }
    }
}
