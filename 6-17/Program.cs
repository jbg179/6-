using System;
class MyException : ApplicationException
{
    public int value;
    public MyException() { } // 생성자
    public MyException(string msg, int i) : base(msg)
    { // 생성자
        value = i;
    }
}
class MsgExceptionApp
{
    static void F(int k)
    {
        if (k < 70 || k > 100)
            throw new MyException();
    }
    static void G(int k)
    {
        if (k > 200)
            throw new MyException("Too Many", k);
        if (k < 50)
            throw new MyException("Too Less", k);
    }
    public static void Main()
    {
        try
        {
            F(50);
        }
        catch (MyException e)
        {
            Console.WriteLine(e.StackTrace);
        }
        try
        {
            G(250);
        }
        catch (MyException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
            Console.WriteLine("Data value is " + e.value + ".");
        }
    }
}
