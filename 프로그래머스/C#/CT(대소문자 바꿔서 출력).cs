using System;
using System.Linq;
public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        var ss = s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        String set = new String(ss.ToArray());
        Console.WriteLine(set);
    }
}