using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_projet_CHARIBO
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = true;
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
