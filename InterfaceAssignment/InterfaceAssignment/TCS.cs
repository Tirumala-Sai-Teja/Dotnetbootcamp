using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    internal class TCS : IGovtRules
    {
        public string empid, name, dept, desg;

        public double basicSalary;
        public TCS(string empid, string name, string dept, string desg, double basicSalary)
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
            var empContribution = basicSalary * 0.0833;
            var pensionFund = empContribution * 0.036;
            PF += empContribution;
            return PF;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            switch (serviceCompleted)
            {
                
                case var sc when sc > 20:
                    return 3*basicSalary;
                case var sc when sc > 10:
                    return 2 * basicSalary;
                case var sc when sc > 5:
                    return basicSalary;
                default: return 0.0;
            }
           
        }

        public string LeaveDetails()
        {
            return ("Casual Leave per month:1, Sick Leaves per Year:12, Previlege Leave per year:10  ");
        }
    }
}
