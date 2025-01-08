using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMToolKitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strMessage=CMToolKitCaller.CMToolKitCaller.FunctionCall("Hello",null,new object[] { "ABC" }) as string;
            if (strMessage != null)
            {
                textBox1.Text = strMessage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CMToolKitCaller.CMToolKitCaller.Init("CMToolKitForBYD.dll", "CMToolKitForBYD.CMToolKitForBYD");
        }
    }
}
