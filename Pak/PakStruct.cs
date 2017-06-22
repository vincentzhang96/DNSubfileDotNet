/* 
<copyright>
    PakHeader.cs

    Copyright (c) 2017 Divinitor

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
</copyright> 
*/

using System;
using System.Text;

namespace Divinitor.DN.Subfile.Pak
{
    public struct Header
    {
        public const uint PakHeaderMagicNumberBufSz = 256;
        public const uint PaddingSz = 756;

        public byte[] MagicNumberBuf;
        private string _magicNumber;
        public uint Version;
        public uint FileCount;
        public uint FileIndexTableOffset;
        public byte[] Padding;

        public string MagicNumber
            => _magicNumber ?? (_magicNumber = MagicNumberBuf.ToUtf8String().TrimNul());
    }

    public struct IndexEntry
    {
        public const uint PathBufSz = 256;
        public const uint PaddingSz = 40;

        public byte[] PathBuf;
        private string _path;
        public uint PhysicalSize;
        public uint MemorySize;
        public uint DiskSize;
        public uint Offset;
        public uint UnknownA;
        public byte[] Padding;

        public string Path
            => _path ?? (_path = PathBuf.ToUtf8String().TrimNul());
    }
}
