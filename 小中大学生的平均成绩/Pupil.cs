using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小中大学生的平均成绩
{
    public class Pupil : Student
    {
        private double chinese;
        private double math;
        public double Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }
        public double Math
        {
            get { return math; }
            set { math = value; }
        }
        public Pupil(string Myname, int Myage, double Mychinese, double Mymath)
            : base(Myname, Myage)
        {
            this.chinese = Mychinese;
            this.math = Mymath;
        }
        public override double GetAverage()//重写学生抽象类中抽象方法
        {
            return (chinese + math) / 2;
        }
    }
}
