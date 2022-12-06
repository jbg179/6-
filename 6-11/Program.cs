using System;
class SystemrExThrowApp
{
    public static void Exp(int ptr)
    {
        if (ptr == 0)
            throw new NullReferenceException();
    }
    public static void Main()
    {
        int i = 0;
        Exp(i);
    }
}
