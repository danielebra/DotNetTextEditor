using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAssignment2.Classes
{
    class Utils
    {
        // Returns all the Controls that match a certain type
        // I.e.: All the text boxes from a form
        static public IEnumerable<Control> GetControlsFromControl(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetControlsFromControl(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
    }
}
