using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMToolKitForBYD
{
    public class CMToolKitForBYD
    {
        public static string Hello(string strMessage)
        {
            MessageBox.Show("Hello Byd"+ strMessage);
            return "i am Byd";
        }
        public static void Init()
        {
            MessageBox.Show("Init() Byd");
        }
    }
}
