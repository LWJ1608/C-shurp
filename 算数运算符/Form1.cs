using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 算数运算符
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num = 4321;
            lblShow.Text += "千位数是：" + num / 1000;
            lblShow.Text += "\n" + "百位数是：" + num / 100 % 10;
            lblShow.Text += "\n" + "十位数是：" + num / 10 % 10;
            lblShow.Text += "\n" + "十位数是：" + num% 10;
        }
    }
}
