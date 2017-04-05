using System;

namespace Array_Equilibrium
{
    internal class Program
    {
        private static void Main()
        {
            var A = new int[] { -5, 11, -4, 5, 1, -6, 12, 6 };
            var result = Solution.SolutionMethod(A);
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
