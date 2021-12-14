using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小中大学生的平均成绩
{
    public class MiddleStu : Student
    {
        private double chinese;
        private double math;
        private double english;
        public MiddleStu(string myname, int myage, double mychinese, double mymath, double myenglish)
            : base(myname, myage)
        {
            chinese = mychinese;
            math = mymath;
            english = myenglish;
        }
        public override double GetAverage()
        {
            return (chinese + math + english) / 3;
        }
    }
}
