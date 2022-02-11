using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Output.Msg = "";
            SumClass sum1 = new SumClass();
            Thread tid1 = new Thread(sum1.Sum);
            tid1.Name = "Thread A";

            SumClass sum2 = new SumClass();
            Thread tid2 = new Thread(sum2.Sum);
            tid2.Name = "Thread B";

            tid1.Start();
            tid2.Start();

            tid1.Join();
            tid2.Join();

            lab_out.Text = Output.Msg;



        }
    }
    class Output
    {
        public static string Msg;
        public static void Add(string str)
        {
            Msg += str + "\r\n";
        }
    }
    class SumClass
    {
        public void Sum()
        {
            long temp=0;
            //lock (this) {
                for (int i = 1; i < 4; i++)
                {
                    Output.Add(Thread.CurrentThread.Name + "-" + i);
                    //Thread.Sleep(new Random().Next(50, 100 + 1));
                    temp += i;
                }
                Output.Add(Thread.CurrentThread.Name + "總和=" + temp);
            //}

        }
    }
}
