﻿using Algorithms.Codility;
using Algorithms.Interview;
using Algorithms.Interview.Array;
using Algorithms.Interview.DictionariesAndHashmaps;
using Algorithms.Interview.GreedyAlgorithms;
using Algorithms.Interview.Miscellaneous;
using Algorithms.Interview.Sorting;
using Interview.Algorithms;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
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

            FlippingBits flipping = new FlippingBits();
            flipping.Solve(2147483647);
        }
    }
}
