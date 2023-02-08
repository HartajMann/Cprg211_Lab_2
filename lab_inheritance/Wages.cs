using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace lab_inheritance
{
    public class Wages:Employee
    {
        private double rate;
        private double hours;
        public Wages() { }

        
        public Wages(string id, string name, string address, string phone, string sin, string dob, string dept,double rate,double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            Hours= hours;
            Rate= rate;
        }

        public double Rate { get=>rate; set=>rate = value; }
        public double Hours { get=>hours; set=>hours = value;}


        public override double getPay()
        {
            double pay = 0;
            if(Hours<=40)
            {
                pay = Hours * Rate;
            }
            else
            {
                pay=40*Rate+(Hours-40)*Hours*1.5;
            }
            return pay;
        }

        public override string ToString()
        {
            return Id+Name+Phone+Address+Sin+Dob+Dept;
        }
    }
}
