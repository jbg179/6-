using System;
using System.Threading;
class SchedulerApp
{
    static int interval;
    static void ThreadBody()
    {
        Thread myself = Thread.CurrentThread; // 현재 스레드 반환
        Console.WriteLine("Starting Thread : " + myself.Name); // 스레드 이름
        for (int i = 1; i <= 3 * interval; i++)
        {
            if (i % interval == 0)
                Console.WriteLine(myself.Name + " : " + i);
        }
        Console.WriteLine("Ending Thread : " + myself.Name);
    }
    public static void Main()
    {
        Console.Write("Interval value : ");
        interval = int.Parse(Console.ReadLine());
        Thread.CurrentThread.Name = "Main Thread"; // 스레드 이름 지정
                                                   //Thread.CurrentThread.Priority = ThreadPriority.Highest;
        Thread worker = new Thread(new ThreadStart(ThreadBody));
        worker.Name = "Worker Thread";
        worker.Start();
        ThreadBody(); // Main Thread에서 ThreadBody() 수행
    }
}
