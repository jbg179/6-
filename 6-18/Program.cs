using System;
using System.Threading; // 반드시 포함 !!!
class SimpleThreadApp
{
    static void ThreadBody()
    { // --- ①
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(DateTime.Now.Second + " : " + i);
            Thread.Sleep(1000); // 1초 동안 스레드 실행을 멈추고 대기 상태
        }
    }
    public static void Main()
    {
        ThreadStart ts = new ThreadStart(ThreadBody); // --- ②
        Thread t = new Thread(ts); // --- ③
        Console.WriteLine("*** Start of Main");
        t.Start(); // --- ④
        Console.WriteLine("*** End of Main");
    }
}