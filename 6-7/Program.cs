﻿using System;
public class MyAttrAttribute : Attribute
{ // 속성 클래스
    public MyAttrAttribute(string message)
    { // 생성자
        this.message = message;
    }
    private string message; // 필드 : 멤버 변수
    public string Message
    { // 프로퍼티
        get { return message; }
    }
}
[MyAttr("This is Attribute test.")]
class MyAttributeApp
{
    public static void Main()
    {
        Type type = typeof(MyAttributeApp);
        object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);
        if (arr.Length == 0)
            Console.WriteLine("This class has no custom attrs.");
        else
        {
            MyAttrAttribute ma = (MyAttrAttribute)arr[0];
            Console.WriteLine(ma.Message);
        }
    }
}