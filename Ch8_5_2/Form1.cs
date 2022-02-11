using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_5_2
{
    public partial class Form1 : Form
    {
        int[] data = { 5, 4, 3, 2, 1 };
        int keyValue, targetIdx;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            data[0] = Convert.ToInt32(tb_0.Text);
            data[1] = Convert.ToInt32(tb_1.Text);
            data[2] = Convert.ToInt32(tb_2.Text);
            data[3] = Convert.ToInt32(tb_3.Text);
            data[4] = Convert.ToInt32(tb_4.Text);
            Array.Sort(data);
            tb_0.Text = data[0].ToString();
            tb_1.Text = data[1].ToString();
            tb_2.Text = data[2].ToString();
            tb_3.Text = data[3].ToString();
            tb_4.Text = data[4].ToString();
        }

        private void bt_LinearSearch_Click(object sender, EventArgs e)
        {
            keyValue = Convert.ToInt32(tb_input.Text);
            targetIdx = 0;
            data[0] = Convert.ToInt32(tb_0.Text);
            data[1] = Convert.ToInt32(tb_1.Text);
            data[2] = Convert.ToInt32(tb_2.Text);
            data[3] = Convert.ToInt32(tb_3.Text);
            data[4] = Convert.ToInt32(tb_4.Text);
            for(int i = 0; i < data.Length; i++)
            {
                if(keyValue == data[i])
                {
                    targetIdx = i;
                    break;
                }
            }
            tb_MSG.Text = "找到鍵值在位值 : " + targetIdx.ToString();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {

            
            targetIdx = 0;
            
            data[0] = Convert.ToInt32(tb_0.Text);
            data[1] = Convert.ToInt32(tb_1.Text);
            data[2] = Convert.ToInt32(tb_2.Text);
            data[3] = Convert.ToInt32(tb_3.Text);
            data[4] = Convert.ToInt32(tb_4.Text);
            keyValue = Convert.ToInt32(tb_input.Text);
            Array.Sort(data);
            //BinarySearch();
            BinarySearch_Platform();
        }

        private void BinarySearch_Platform()
        {
            bool isFound =false;
            targetIdx= Array.BinarySearch(data, keyValue);
            isFound = (targetIdx >= 0) ? true : false;
            if (isFound)
            {
                tb_MSG.Text = "找到鍵值在位值 : " + targetIdx.ToString();
            }
            else
            {
                tb_MSG.Text = "沒有找到鍵值 ";
            }
        }
    
        private void BinarySearch()
        {
            int high = 0, low = 0, mid = 0;
            bool isFound = false;
            high = data.Length - 1;
            do
            {
                mid = (low + high) / 2;
                if (data[mid] == keyValue)
                {
                    targetIdx = mid;
                    isFound = true;
                    break;
                }
                else if (data[mid] > keyValue)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            } while (low <= high);
            if (isFound)
            {
                tb_MSG.Text = "找到鍵值在位值 : " + targetIdx.ToString();
            }
            else
            {
                tb_MSG.Text = "沒有找到鍵值 ";
            }
        }
    }
}
