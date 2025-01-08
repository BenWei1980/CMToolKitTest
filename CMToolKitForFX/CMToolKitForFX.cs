using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMToolKitForFX
{
    public class CMToolKitForFX
    {
        public static string Hello(string strMessage)
        {
            MessageBox.Show("Hello Fx"+ strMessage);
            return "I am FX";
        }
        public static void Init()
        {
            MessageBox.Show("Init() FX");
        }
    }
}
