using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_6_form
{
    public partial class PA6 : Form
    {
        public PA6()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain myForm = new frmMain(txtCWID.Text);
            if(myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
