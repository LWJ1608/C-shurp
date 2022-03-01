using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 酒店人员信息管理系统
{
    public abstract class Employee //定义员工抽象类
    {
        //1.定义员工的信息字段
        private string empId;        //员工编号
        private string empName;      //员工姓名
        private string empIdNumber;  //员工身份证号
        private string empHealth;    //员工健康证号
        private string empPhone;     //员工电话
                                     
        //2.属性封装字段
        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public string EmpIdNumber
        {
            get { return empIdNumber; }
            set { empIdNumber = value; }
        }
        public string EmpHealth
        {
            get { return empHealth; }
            set { empHealth = value; }
        }
        public string EmpPhone
        {
            get { return empPhone; }
            set { empPhone = value; }
        }

        //3.构造函数对字段进行初始化
        public Employee(string id, string name, string idNumber, string health, string phone)
        {
            this.empId = id;
            this.empName = name;
            this.empIdNumber = idNumber;
            this.empHealth = health;
            this.empPhone = phone;
        }
        //4.计算员工工资的抽象方法
        public abstract double GetSalary();
        //5.获取员工信息的方法
        public string ToSalary()
        {
            return string.Format("员工编号：{0}\n员工姓名：{1}\n员工身份证号：{2}\n员工健康证号：{3}\n电话：{4}", EmpId, EmpName, EmpIdNumber, EmpHealth, EmpPhone);
        }
    }
}

