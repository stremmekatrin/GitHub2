using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGitHub2
{
    public partial class Form1 : Form
    {
        private bool kappapride = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kappapride)
            {
                kappapride = false;
                button1.Text = "Kappapride";
                this.BackgroundImage = new Bitmap(Properties.Resources.kappa);
            }
            else
            {
                kappapride = true;
                button1.Text = "Kappa";
                this.BackgroundImage = new Bitmap(Properties.Resources.kappapride);
            }
        }
    }
}
