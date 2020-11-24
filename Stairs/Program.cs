using System;

namespace Stairs
{
    internal class Program
    {
        private static readonly Printer printer = new Printer();
        
        internal static void Main(string[] args)
        {
            int[] stairs = { 1, 100, 1, 1, 100, 1, 1, 1 };

            Console.WriteLine(printer.Print(stairs));
            
            Node idxTree = BuildPossiblePathsTree(stairs);
            int[] minEffortStairs = CalculateMinEffortStairs(idxTree, stairs);
            
            Console.WriteLine(printer.Print(stairs, minEffortStairs));
        }

        private static Node BuildPossiblePathsTree(int[] stairs)
        {
            return null;
        }

        private static int[] CalculateMinEffortStairs(Node idxTree, int[] stairs)
        {
            return null;
        }
    }
}
