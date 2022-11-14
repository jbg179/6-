using System;

interface IGenericInterface<T>
{
    void SetValue(T x);
    string GetValueType();
}
class GenericClass<T> : IGenericInterface<T>
{
    private T value;
    public void SetValue(T x)
    {
        value = x;
    }
    public String GetValueType()
    {
        return value.GetType().ToString();
    }
}


public class GenericInterfaceApp
{
    public static void Main()
    {
        GenericClass<Int32> gInteger = new GenericClass<Int32>();
        GenericClass<String> gString = new GenericClass<String>();
        gInteger.SetValue(10);
        gString.SetValue("Text");
        Console.WriteLine(gInteger.GetValueType());
        Console.WriteLine(gString.GetValueType());
    }
}
