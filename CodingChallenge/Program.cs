using System;

namespace CodingChallenge.ReversingString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringUtilities StringUtilities = new StringUtilities();
            String Result = StringUtilities.Reverse("Hello Foo");
            Console.WriteLine(Result);
        }
    }
}
