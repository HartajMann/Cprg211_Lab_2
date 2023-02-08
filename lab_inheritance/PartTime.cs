using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_inheritance
{
    public class PartTime:Employee
    {
        private double rate;
        private double hours;

        public PartTime()
        {

        }

        public PartTime(string id, string name, string address, string phone, string sin, string dob, string dept,double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            Rate = rate;
            Hours = hours;
        }

        public double Rate { get=>rate; set=>rate = value; }
        public double Hours { get=>hours;set=>hours = value; }

        public override double getPay()
        {
            return Hours * Rate;
        }

        public override string ToString()
        {
            return Id + Name + Phone + Address + Sin + Dob + Dept;

        }
    }
}
