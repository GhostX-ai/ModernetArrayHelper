using System;

namespace NewArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods<string> M = new Methods<string>();
            string[] z = { "A", "B", "C", "D" };
            // M.Slice(ref z, 2);
            M.Slice(ref z, 1, 3);
            Console.ReadKey();
        }
    }
}
