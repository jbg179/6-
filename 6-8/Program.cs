using System;
class UserErrException : ApplicationException
{
    public UserErrException(string s) : base(s) { } // 생성자
}
class UserException
{
    public static void Main()
    {
        try
        {
            throw new UserErrException("throw a exception with a message");
        }
        catch (UserErrException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}