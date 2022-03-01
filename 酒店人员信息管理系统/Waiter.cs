using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 酒店人员信息管理系统
{
    public class Waiter : Employee //定义一个服务员类
    {
        //1.扩展服务员类字段
        private int watCount;    //工作小时数
        private double watWage;  //每小时工资标准
        //2.属性封装字段
        public int WatCount
        {
            get { return watCount; }
            set { watCount = value; }
        }
        public double WatWage
        {
            get { return watWage; }
            set { watWage = value; }
        }
        //3.构造函数初始化字段
        public Waiter(int count, double wage, string id, string name, string idNumber, string health, string phone)
            : base(id, name, idNumber, health, phone)
        {
            this.watCount = count;
            this.watWage = wage;
        }
        //4.重写员工工资的抽象方法（按工作小时数*每小时工资额计算）
        public override double GetSalary()
        {
            return WatCount * WatWage;
        }
    }
}

