using System;
using System.Text.RegularExpressions;

namespace DOTReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a...........bc...de..................f...ghi........jkl";
            string ss = Regex.Replace(s, @"\.+", ".");
            Console.WriteLine(ss);
            Console.ReadLine();
        }
    }
}