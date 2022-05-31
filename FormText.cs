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
    public partial class FormText : Form1
    {

        public FormText()
        {
            InitializeComponent();
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            f = 0;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            f = 1;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
