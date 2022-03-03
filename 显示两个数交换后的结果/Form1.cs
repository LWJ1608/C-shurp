using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 显示两个数交换后的结果
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //交换前
            int tmp = 0;
            int a = 88;
            int b = 99;
            lblShow.Text += string.Format("交换前：a={0},b={1}\n", a, b);
            //交换后
            tmp = a;
            a = b;
            b = tmp;
            lblShow.Text += string.Format("交换后：a={0},b={1}", a, b);
        }
    }
}
