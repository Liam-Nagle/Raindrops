using System;
using System.Text;

namespace Raindrops
{
    public class RaindropsClass
    {
        public static string PlingPlangPlong(int n)
        {
            var sb = new StringBuilder();
            if(n % 3 == 0)
            {
                sb.Append("Pling");
            }
            if(n % 5 == 0)
            {
                sb.Append("Plang");
            }
            if(n % 7 == 0)
            {
                sb.Append("Plong");
            }
            if(string.IsNullOrEmpty(sb.ToString()))
            {
                sb.Append(n.ToString());
            }

            return sb.ToString();
        }
    }
}
