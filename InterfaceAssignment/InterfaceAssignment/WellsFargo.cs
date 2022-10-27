using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    internal class WellsFargo
    {
        public string empid, name, dept, desg;

        public double basicSalary;
        public WellsFargo(string empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {

            var PF = basicSalary * 0.12;
            var empContribution = basicSalary * 0.12;
            var pensionFund = empContribution * 0.036;
            PF += empContribution;
            return PF;
        }


        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            Console.WriteLine("not applicable");
             return 0.0;

        }
        public string LeaveDetails()
        {
            return ("Casual Leave per month:2, Sick Leaves per Year:5,b  Previlege Leave per year:10  ");
        }
    }

    }
