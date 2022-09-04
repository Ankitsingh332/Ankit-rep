﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_sept
{
    internal class Shellsort
    {
        static void Main(string[] args)
        {
            ShellSort();
            Console.Read();

        }
        static void printAll(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        static void ShellSort()
        {
            int[] arr = new int[] { 15, 23, 52, 16, 19, 29, 36, 17, 34 };
            int inner, outer, valueToInsert, interval = 1, i = 0;
            Console.WriteLine("Before Sort the array=");
            printAll(arr);
            Console.WriteLine("----------------------------");
            while (interval <= ((arr.Length) / 3))
            {
                //  h=h*3+1
                interval = interval * 3 + 1;
            }
            while (interval > 0)
            {
                for (outer = 0; outer < arr.Length; outer++)
                {
                    valueToInsert = arr[outer];
                    inner = outer;
                    while ((inner > interval - 1) && (arr[inner - interval] >= valueToInsert))
                    {
                        arr[inner] = arr[inner - interval];
                        inner = inner - interval;
                        Console.WriteLine("Item moved= " + arr[inner]);
                    }
                    arr[inner] = valueToInsert;
                    Console.WriteLine("Item inserted at =" + arr[inner]);
                }
                interval = (interval - 1) / 3;
                i += 1;
            }
            Console.WriteLine("After Sort the array=");
            printAll(arr);

        }
    }
}