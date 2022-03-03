using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 显示学生信息_采用属性来封装私有成员_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Student
        {
            private string stuId;
            private string stuName;
            private string stuSex;
            private int stuAge;
            private string stuSpecialty;

            public string StuId
            {
                get { return stuId; }
                set { stuId = value; }
            }
            public string StuName
            {
                get { return stuName; }
                set { stuName = value; }
            }

            public string StuSex;
            {
                get { return stuSex; }
                set { stuSex = value; }
            }
            public int StuAge
            {
                get { return stuAge; }
                set { stuAge = value; }
            }
            public int StuSpecialty
            {
                get { return stuSpecialty; }
                set { stuSpecialty = value; }
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
