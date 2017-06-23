// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Divinitor" file="PakStruct.cs">
//   MIT License.
// </copyright>
// <summary>
//   Contains various Pak-related structs
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace Divinitor.DN.Subfile.Pak
{
    public struct Header
    {
        public const uint MagicNumberBufSz = 256;
        public const uint PaddingSz = 756;

        public byte[] MagicNumberBuf;
        public uint Version;
        public uint FileCount;
        public uint FileIndexTableOffset;
        public byte[] Padding;

        private string magicNumber;

        public string MagicNumber
            => this.magicNumber ?? (this.magicNumber = this.MagicNumberBuf.ToUtf8String().TrimNul());
    }

    public struct IndexEntry
    {
        public const uint PathBufSz = 256;
        public const uint PaddingSz = 40;

        public byte[] PathBuf;
        public uint PhysicalSize;
        public uint MemorySize;
        public uint DiskSize;
        public uint Offset;
        public uint UnknownA;
        public byte[] Padding;
        private string path;

        public string Path
            => this.path ?? (this.path = this.PathBuf.ToUtf8String().TrimNul());

        public bool IsInvalid => this.MemorySize == 0;

    }
}
