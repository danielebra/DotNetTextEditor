using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAssignment2.Classes
{
    // Define key combinations to perform actions
    public static class HotKeys
    {
        public static bool Save(Keys keys)
        {
            return keys == (Keys.Control | Keys.S);
        }
        public static bool Open(Keys keys)
        {
            return keys == (Keys.Control | Keys.O);
        }
        public static bool New(Keys keys)
        {
            return keys == (Keys.Control | Keys.N);
        }
        public static bool Cut(Keys keys)
        {
            return keys == (Keys.Control | Keys.X);
        }
        public static bool Copy(Keys keys)
        {
            return keys == (Keys.Control | Keys.C);
        }
        public static bool Paste(Keys keys)
        {
            return keys == (Keys.Control | Keys.V);
        }
    }
}
