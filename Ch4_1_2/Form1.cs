using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        int counter;
        public Form()
        {
            InitializeComponent();
            counter = 0;
        }

        private void Bu_Int_Click(object sender, EventArgs e)
        {
            counter++;
              
            this.Text = "標題 : "+counter.ToString();
        }

        private void Bu_Rest_Click(object sender, EventArgs e)
        {
            counter = 0;
            this.Text = "標題 : "counter.ToString();
        }

        private void Bu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
