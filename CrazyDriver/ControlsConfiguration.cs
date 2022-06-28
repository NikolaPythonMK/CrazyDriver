using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    [Serializable]
    public class ControlsConfiguration
    {
        public static Keys leftControl = Keys.Left;
        public static Keys rightControl = Keys.Right;
        public static bool menuMusic = true;
        public static bool gameMusic = true;
        public static bool lettersControls = false;
        public static bool arrowsControls = true;
    }
}
