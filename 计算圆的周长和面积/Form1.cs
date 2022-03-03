using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算圆的周长和面积
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //
            double PI = 3.14;
            //输入半径
            double R = Convert.ToDouble(txtR.Text);
            //周长
            double C = 2 * PI * R;
            //面积
            double S = PI * R * R;

            lblShow.Text += string.Format("半径：{0}，周长：{1}，面积：{2}\n", R, C, S);
        }
    }
}
