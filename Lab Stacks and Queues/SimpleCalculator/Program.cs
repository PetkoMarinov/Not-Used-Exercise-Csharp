﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                // Console.WriteLine(string.Join(" ",stack));
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+": stack.Push((first + second).ToString()); break;
                    case "-": stack.Push((first - second).ToString()); break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
