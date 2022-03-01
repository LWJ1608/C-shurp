using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 酒店人员信息管理系统
{
    public class Cook : Employee
    {
        //1.扩展私有字段
        private string ckLevel;
        private double ckSalary;
        //2.属性保护字段
        public string CkLevel
        {
            get { return ckLevel; }
            set { ckLevel = value; }
        }
        public double CkSalary
        {
            get { return ckSalary; }
            set { ckSalary = value; }
        }
        //3.构造函数初始化字段
        public Cook(string level, double salary, string id, string name, string idNumber, string health, string phone)
            : base(id, name, idNumber, health, phone)
        {
            this.ckLevel = level;
            this.ckSalary = salary;
        }
        //4.重写员工工资的抽象方法（按月计算工资额）
        public override double GetSalary()
        {
            return ckSalary;
        }
    }
}

