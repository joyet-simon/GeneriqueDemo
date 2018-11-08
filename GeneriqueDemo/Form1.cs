using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneriqueDemo
{
    public partial class Form1 : Form
    {
        Int32 nbrClick = 5;
        Alea<Int32> loto = new Alea<int>();
        Alea<Int32> loto2 = new Alea<int>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 50; i++) { loto.add(i); }
            for (int i = 1; i <= 10; i++) { loto2.add(i); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 num = loto.getAleaUnique();
            nbrClick--;
            textBox1.AppendText(num.ToString() + ". ");
            if (nbrClick == 0)
            {
                Int32 numComp = loto2.getAleaUnique();
                textBox1.AppendText("-> " + numComp.ToString() + ". ");
                button1.Enabled = false;
            }
        }

    }
}
