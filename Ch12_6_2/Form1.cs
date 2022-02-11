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

namespace Ch12_6_2
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_thread_Click(object sender, EventArgs e)
        {
            Output.MSG = "執行緒不同步\n";
            Printer print = new Printer();
            Thread[] thrd = new Thread[] { new Thread(print.PrintNumber) ,
                new Thread(print.PrintNumber),new Thread(print.PrintNumber)}  ;
            thrd[0].Name = "T0"; thrd[1].Name = "T1"; thrd[2].Name = "T2";
            thrd[0].Start(); thrd[1].Start(); thrd[2].Start();
            Thread.Sleep(500);
            lab_out.Text = Output.MSG;
        }

        private void bt_thread2_Click(object sender, EventArgs e)
        {
            Output.MSG = "執行緒同步lock\n";
            Printer print = new Printer();
            Thread[] thrd = new Thread[] { new Thread(print.SPrintNumber) ,
                new Thread(print.SPrintNumber),new Thread(print.SPrintNumber)};
            thrd[0].Name = "T0"; thrd[1].Name = "T1"; thrd[2].Name = "T2";
            thrd[0].Start(); thrd[1].Start(); thrd[2].Start();
            Thread.Sleep(500);
            lab_out.Text = Output.MSG;
        }

        private void bt_thread3_Click(object sender, EventArgs e)
        {
            Output.MSG = "執行緒同步Monitor\n";
            Printer print = new Printer();
            Thread[] thrd = new Thread[] { new Thread(print.MPrintNumber) ,
                new Thread(print.MPrintNumber),new Thread(print.MPrintNumber)};
            thrd[0].Name = "T0"; thrd[1].Name = "T1"; thrd[2].Name = "T2";
            thrd[0].Start(); thrd[1].Start(); thrd[2].Start();
            Thread.Sleep(500);
            lab_out.Text = Output.MSG;
        }
    }
    class Output
    {
        public static string MSG;
        public static void Add(string str)
        {
            MSG += str;
        }
    }
    class Printer
    {
        public void PrintNumber()
        {
            for (int i = 1; i <= 5; i++)
            {
                Output.Add(Thread.CurrentThread.Name+ "[" + i + "]"+"\n");
                Thread.Sleep(new Random().Next(5, 20));
            }
            Output.Add("\r\n");
        }

        public void SPrintNumber()
        {
            lock (this)             //鎖定同步執行續
            {
                for (int i = 1; i <= 5; i++)
                {
                    Output.Add(Thread.CurrentThread.Name + "[" + i + "]" + "\n");
                    Thread.Sleep(new Random().Next(5, 20));
                }
                Output.Add("\r\n");
            }
        }
        public void MPrintNumber()
        {
            Monitor.Enter(this);        //同步執行續
            {
                for (int i = 1; i <= 5; i++)
                {
                    Output.Add(Thread.CurrentThread.Name + "[" + i + "]" + "\n");
                    Thread.Sleep(new Random().Next(5, 20));
                }
                Output.Add("\r\n");
            }
            Monitor.Exit(this);
            
        }
    }
}
