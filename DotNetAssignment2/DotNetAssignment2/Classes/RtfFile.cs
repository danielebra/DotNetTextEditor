using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    struct RtfFile
    {
        // Rtf file data type to handle saving
        public string Contents { get; set; }
        public string FilePath { get; set; }

        public void Save()
        {
            File.WriteAllText(this.FilePath, this.Contents);
        }
    }
}
