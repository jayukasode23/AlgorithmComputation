﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BubbleSort
    {
        public void CheckBobbleSorting()
        {
            int[] arr = { 89, 98, 45, 54, 36 };
            int temp;
            for (int j = 1; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted : ");
            foreach (int p in arr)
                Console.WriteLine(p + " ");

        }
    }
}