using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_inheritance
{
    public class Salaried:Employee
    {
        private double salary;

        public Salaried()
        {
        }

        public Salaried(string id, string name, string address, string phone, string sin, string dob, string dept,double salary) : base(id, name, address, phone, sin, dob, dept)
        {
            Salary= salary;
        }

        public double Salary { get => salary; set => salary = value; }

        public override double getPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return Id+Name+Phone+Address+Sin+Dob+Dept;

        }
    }
}
