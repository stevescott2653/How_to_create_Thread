﻿using System;
using System.Threading.Tasks;

namespace How_to_create_Thread
{
    using System.Threading;

    public class ThreadExample
    {
        public static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine(t.Name);
        }
    }
}
