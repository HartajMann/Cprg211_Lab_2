using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_inheritance
{
    public class Main_class
    {
        static List<Employee> list = new List<Employee>();
        public static void Main(string[] args)
        {
            loadcoursefiles();
            avg();
            highPay();
            lowPay();
            EmpType();
        }
        public static void loadcoursefiles()
        {
            string path = "C:\\Users\\Harthaj\\Documents\\sait-sem2\\oops_2\\lab_2\\lab_inheritance\\lab_inheritance\\res\\employees.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] splitline = line.Split(':');
                if (splitline[0].StartsWith("0") || splitline[0].StartsWith("1") || splitline[0].StartsWith("2") || splitline[0].StartsWith("3") || splitline[0].StartsWith("4"))
                {
                    Salaried salaried = new Salaried(splitline[0], splitline[1], splitline[2], splitline[3], splitline[4], splitline[5], splitline[6], double.Parse(splitline[7]));
                    list.Add(salaried);
                }
                else if (splitline[0].StartsWith("5") || splitline[0].StartsWith("6") || splitline[0].StartsWith("7"))
                {
                    Wages w = new Wages(splitline[0], splitline[1], splitline[2], splitline[3], splitline[4], splitline[5],splitline[6], double.Parse(splitline[7]), double.Parse(splitline[8]));
                    list.Add(w);

                }
                else if (splitline[0].StartsWith("8") || splitline[0].StartsWith("9"))
                {
                    PartTime p = new PartTime(splitline[0], splitline[1], splitline[2], splitline[3], splitline[4], splitline[5],splitline[6], double.Parse(splitline[7]), double.Parse(splitline[8]));
                    list.Add(p);
                }
            }
        }
        public static void avg()
        {
            double avgpay = 0;
            foreach (Employee emp in list)
            {
                avgpay += emp.getPay();
            }
            avgpay = avgpay / list.Count;
            Console.WriteLine("The Average pay for all employees is:" + avgpay);
        }
        public static void highPay()
        {
            double highestpay = double.MinValue;
            string empName = "";
            foreach (Employee emp in list)
            {
                if (emp is Wages)
                {
                    Wages w = (Wages)emp;
                    if (w.getPay() > highestpay)
                    {
                        highestpay = w.getPay();
                        empName = emp.Name;
                    }
                }
            }
            Console.WriteLine("The wages employee with highest pay is:" + highestpay + " " + empName);
        }
        public static void lowPay()
        {
            double lowpay = double.MaxValue;
            string empName = "";
            foreach (Employee emp in list)
            {
                if (emp is Salaried)
                {
                    Salaried s = (Salaried)emp;
                    if (s.Salary < lowpay)
                    {
                        lowpay = s.Salary;
                        empName = emp.Name;
                    }
                }
            }
            Console.WriteLine("The Salaried employee with lowestest pay is:" + lowpay + " " + empName);
        }
        public static void EmpType()
        {
            double sal = 0;
            double wage = 0;
            double part_time = 0;
            foreach (Employee emp in list)
            {
                if(emp is Salaried)
                {
                    sal++;
                }
                else if(emp is Wages)
                {
                    wage++;
                }
                else
                {
                    part_time++;
                }
            }
            double salper=sal/list.Count*100;
            double wageper = wage / list.Count * 100;
            double partper = part_time / list.Count * 100;
            Console.WriteLine("Percentage of Salaried employee is:" + salper +"%"+ "\nPercentage of Wage employee is:"+wageper+"%"+ "\nPercentage of Part Time employee is:"+partper+"%");
            Console.ReadKey();
        }
    }
}
