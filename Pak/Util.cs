// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Divinitor" file="Util.cs">
//   MIT License. See LICENSE file.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text;

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
