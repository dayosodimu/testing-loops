﻿using System;

namespace testing_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 10; i = i + 2)
            {
                Console.Write(i);
            }
        }
    }
}
