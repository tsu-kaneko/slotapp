using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num;
            for (int i = 0; i < 600; i++)
            {
                if (i < 200)
                {
                    num = rnd.Next(10);
                    label1.Text = num.ToString();
                    label1.Refresh();
                }
                if (i < 400)
                {
                    num = rnd.Next(10);
                    label2.Text = num.ToString();
                    label2.Refresh();
                }
                num = rnd.Next(10);
                label3.Text = num.ToString();
                label3.Refresh();
            }
        }
    }
}
