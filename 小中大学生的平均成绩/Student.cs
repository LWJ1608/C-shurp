using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小中大学生的平均成绩
{
        public abstract class Student  //定义学生抽象基类
        {
            private string stuName;
            private int stuAge;
            public static int count;
            public string StuNanme
            {
                get { return stuName; }
                set { stuName = value; }
            }
            public int StuAge
            {
                get
                {
                    if (stuAge <= 0) { return 0; }
                    else { return stuAge; }
                }
            }
            public Student(string Myname, int Myage)
            {
                this.stuName = Myname;
                this.stuAge = Myage;
                count++;
            }
            public abstract double GetAverage(); //抽象方法
        }
    
}
