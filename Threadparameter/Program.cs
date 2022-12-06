﻿using System;
using System.Threading;
namespace Thread_parameter_passing_2
{
    class ThreadParam
    {
        public int Value1;
        public int Value2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            ThreadParam param = new ThreadParam();
            param.Value1 = 10;
            param.Value2 = 20;
            t.Start(param);
        }
        static void threadFunc(object initialValue)
        {
            ThreadParam value = (ThreadParam)initialValue; // downcasting after upcasting
            Console.WriteLine("{0}, {1}", value.Value1, value.Value2);
        }
    }
}
