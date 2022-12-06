using System;
class UserExceptionOne : ApplicationException { }
class UserExceptionTwo : ApplicationException { }
class ExceptionHandlerApp
{
    static void method(int i)
    {
        if (i == 1) throw new UserExceptionOne();
        else throw new UserExceptionTwo();
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("Here: 1");
            method(2);
            Console.WriteLine("Here: 2");
        }
        catch (UserExceptionOne o)
        {
            Console.WriteLine("UserExceptionOne is occurred !!!");
        }
        catch (UserExceptionTwo t)
        {
            Console.WriteLine("UserExceptionTwo is occurred !!!");
        }
        Console.WriteLine("Here: 3");
    }
}