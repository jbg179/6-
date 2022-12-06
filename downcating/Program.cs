using System;
using System.Threading;
namespace Thread_parameter_passing_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.Start(10);
        }
        static void threadFunc(object initialValue)
        {
            int intValue = (int)initialValue;
            Console.WriteLine(intValue);
        }
    }
}
