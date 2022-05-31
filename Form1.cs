using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsColor
{
    public partial class Form1 : Form
    {


        public int f = 0;
        public Form1()
        {

            InitializeComponent();
            textBox1.Focus();
            textBox1.ReadOnly = false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
            FormText formtext = new FormText();
            formtext.ShowDialog();
            if (f == 0)
            {
                textBox1.ReadOnly= !textBox1.ReadOnly;

            }


        }

       
    }
}
