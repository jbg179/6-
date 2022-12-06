using System;
using System.Threading;
class ThreadProperty
{
    public void ThreadBody()
    {
        Thread myself = Thread.CurrentThread; // 실행중인 자신의 스레드 객체 반환
        Monitor.Enter(this);
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("{0} is activated => {1}", myself.Name, i); // 스레드 이름
        Thread.Sleep(1000); // 1초 지연
    }
    Monitor.Exit(this);
    }
}
class ThreadPropertyApp
{
    public static void Main()
    {
        ThreadProperty obj = new ThreadProperty();
        ThreadStart ts = new ThreadStart(obj.ThreadBody);
        Thread t1 = new Thread(ts);
        Thread t2 = new Thread(ts);
        t1.Name = "Apple"; t2.Name = "Orange";
        t1.Start(); t2.Start();
    }
}