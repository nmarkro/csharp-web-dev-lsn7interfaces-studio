using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int TotalSize { get; set; }
        public int UsedSize { get; set; }
        public bool Writeable { get; set; }
        public List<byte> Contents { get; set; }

        public BaseDisc(string name, int totalSize, bool writeable)
        {
            this.Name = name;
            this.TotalSize = totalSize;
            this.UsedSize = 0;
            this.Writeable = writeable;
            this.Contents = new List<byte>();
        }

        public int SizeLeft()
        {
            return TotalSize - UsedSize;
        }

        public string WriteData(List<byte> data, int size)
        {
            if (!Writeable)
            {
                return "Unable to Write to " + Name + ": Disc is read-only";
            }
            if (size > SizeLeft())
            {
                return "Unable to Write to " + Name + ": Not enough space";
            }
            Contents.AddRange(data);
            UsedSize += size;
            return "Successfully wrote " + size + " bytes to " + Name;
        }
    }
}
