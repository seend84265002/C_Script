using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_2_3
{
    public partial class Form1 : Form
    {
        int[] scores = { 90, 55, 67, 88, 75, 89 };
        string[] names = { "Andy", "Bill", "Coral", "David", "Eric", "Fitch" };
        string msg = "";
        int low,higth;

        public Form1()
        {
            InitializeComponent();
            low = names.GetLowerBound(0);
            higth = names.GetUpperBound(0);
        }

        private void bt_name_Click(object sender, EventArgs e)
        {
            
            msg = "";
            msg += "姓名" + "\t" + "成績\r\n";
            msg += "-----------------------\r\n";
            for (int idx = low; idx<=higth;idx++)
            {
                msg += names[idx] + "\t" + scores[idx] + "\r\n";
            }
            tb_MSG.Text = msg;
        }

        private void bt_Score_Click(object sender, EventArgs e)
        {
            msg = "";
            double sum = 0;
            foreach (var ee in scores)
            {
                sum += ee;
                
            }msg += "總和:\t"+sum+"\r\n";
            msg += "平均分數:\t" + (sum / scores.Length).ToString("0.00") + "\r\n";
            tb_MSG.Text = msg;
        }
    }
}
