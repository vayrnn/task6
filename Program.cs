using System;
using CrossPlatformUtils;

class Program
{
    static void Main()
    {
        Console.WriteLine(StringUtils.Reverse("CrossPlatform"));
        Console.WriteLine(NumberUtils.ParseIntOrDefault("123", -1));
        Console.WriteLine(NumberUtils.ParseIntOrDefault("ABC", -1));
    }
}
