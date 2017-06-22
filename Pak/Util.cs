using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divinitor.DN.Subfile.Pak
{
    internal static class Util
    {
        public const char Nul = '\x00';

        public static string TrimNul(this string s)
        {
            return s.TrimEnd(Nul);
        }

        public static string ToUtf8String(this byte[] b)
        {
            return Encoding.UTF8.GetString(b);
        }

    }
}
