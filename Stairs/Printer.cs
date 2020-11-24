using System;
using System.Linq;
using System.Text;

namespace Stairs
{
    public class Printer
    {
        public string Print(int[] stairs)
        {
            StringBuilder builder = new StringBuilder();
            int n = stairs.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                builder.Append(new string(' ', i > 0 ? i * 4 : 0));
                builder.Append($"[{i,3}]");
                builder.AppendLine();
            }

            return builder.ToString();
        }
        
        public string Print(int[] stairs, int[] markedIdxs)
        {
            StringBuilder builder = new StringBuilder();
            int n = stairs.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                builder.Append(new string(' ', i > 0 ? i * 4 : 0));
                builder.Append($"[{i,3}]");

                if (markedIdxs.Contains(i))
                {
                    builder.Append(" *");
                }
                
                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
