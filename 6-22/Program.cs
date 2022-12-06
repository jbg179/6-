using System;
using System.Threading;
class ThreadPriorityApp
{
    static void ThreadBody()
    {
        Thread.Sleep(1000);
    }
    public static void Main()
    {
        Thread t = new Thread(new ThreadStart(ThreadBody));
        t.Start();
        Console.WriteLine("Current Priority : " + t.Priority);
        ++t.Priority;
        Console.WriteLine("Higher Priority : " + t.Priority);
    }
}