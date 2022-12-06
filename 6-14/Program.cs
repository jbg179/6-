using System;
class SystemHandlerApp
{
    public static void Main()
    {
        int[] vector = { 1, 2, 3 };
        try
        {
            Console.WriteLine("Here: 1");
            vector[4] = 4;
            Console.WriteLine("Here: 2");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("System Exception is occurred !!!");
        }
        Console.WriteLine("Here: 3");
    }
}