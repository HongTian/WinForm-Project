using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.UI
{
    public class Button : System.Windows.Forms.Button, ITheme
    {
        public string ControlType
        {
            get
            {
                return "Button";
            }
        }
    }
}
