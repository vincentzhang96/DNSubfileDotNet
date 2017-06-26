// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Divinitor" file="Pak.cs">
//   MIT License. See LICENSE file.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Divinitor.DN.Subfile.Pak
{

    public class Pak
    {
        public Header Header { get; internal set; }
        internal IDictionary<string, IndexEntry> Index { get; set; }

        public IndexEntry this[string path] => Index[path];
    }
}
