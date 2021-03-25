using System;

namespace MergeNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma"};
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2)));
        }
    }
}
