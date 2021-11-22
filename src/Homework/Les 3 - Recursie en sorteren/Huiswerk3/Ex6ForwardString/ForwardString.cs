﻿using System.Collections.Generic;

namespace AD
{
    public class Opgave6
    {
        public static string ForwardString(List<int> list, int from)
        {
            string numbers = "";
            if (list.Count == 0)
                return "";
            foreach (int i in list)
            {
                if (list[i] >= from)
                {
                    numbers += $"{list[i]} ";
                }
            }
            return numbers;
        }

        public static string BackwardString(List<int> list, int to)
        {
            string numbers = "";
            if (list.Count == 0)
                return "";
            for (int i = list[list.Count - 1]; i >= 0; i--)
            {
                if (list[i] >= to)
                    numbers += $"{list[i]} ";
            }
            return numbers;
        }

        public static void Run()
        {
            List<int> list = new List<int>(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11});

            System.Console.WriteLine(ForwardString(list, 3));
            System.Console.WriteLine(ForwardString(list, 7));
            System.Console.WriteLine(BackwardString(list, 3));
            System.Console.WriteLine(BackwardString(list, 7));
        }
    }
}
