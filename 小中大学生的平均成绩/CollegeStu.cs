using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小中大学生的平均成绩
{
    class CollegeStu : Student
    {
        private double obligatory;
        private double elective;
        public CollegeStu(string myname, int myage, double myobligatory, double myelective)
            : base(myname, myage)
        {
            obligatory = myobligatory;
            elective = myelective;
        }
        public override double GetAverage()
        {
            return (obligatory + elective) / 2;
        }
    }
}
