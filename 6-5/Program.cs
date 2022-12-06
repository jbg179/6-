#define CSHARP
using System;
using System.Diagnostics;
class ConditionalAttrApp
{
    [Conditional("CSHARP")]
    public static void CsharpMethod()
    {
        Console.WriteLine("In the CSharp Method ...");
    }
    [Conditional("JAVA")]
    public static void JavaMethod()
    {
        Console.WriteLine("In the Java Method ...");
    }
    public static void Main()
    {
        ConditionalAttrApp.CsharpMethod();
        ConditionalAttrApp.JavaMethod();
    }
}
