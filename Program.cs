using System;

class Program
{
    static void Main()
    {
        string input = "Hello, World!";
        string reversed = ReverseString(input);

        Console.WriteLine("Original String: " + input);
        Console.WriteLine("Reversed String: " + reversed);
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

