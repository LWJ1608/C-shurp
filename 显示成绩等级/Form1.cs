using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 显示成绩等级
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(txtScore.Text);
            while(true)
            {
                if (score < 60)
                {
                    lblShow.Text += "\n" + "不及格！";
                    break;
                }
                if (score > 60 && score <= 70)
                {
                    lblShow.Text += "\n" + "及格！";
                    break;
                }
                if (score < 85 && score > 70)
                {
                    lblShow.Text += "\n" + "良好！";
                    break;
                }
                if (score <= 100 && score > 85)
                {
                    lblShow.Text += "\n" + "优秀！";
                    break;
                }
                else
                {
                    lblShow.Text += "\n" + "成绩输入有误！";
                    continue;
                }
            }

        }
    }
}
