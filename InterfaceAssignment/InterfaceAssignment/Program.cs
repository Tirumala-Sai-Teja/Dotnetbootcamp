using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    class Company
    {
        public static void Main(string[] args)
        {
            TCS t1 = new TCS("a1", "raman", "TCOO", "Program Associate", 350000);
            WellsFargo w1 = new WellsFargo("a2", "sri","TCOO","Program Associate",550000);

            Console.WriteLine("employee ID"+ t1.EmployeePF(350000));

            Console.WriteLine("Gratuity Amount"+t1.gratuityAmount(10, 35000));
            Console.WriteLine("Leave Details:"+t1.LeaveDetails());
            Console.WriteLine("Employee ID:"+w1.EmployeePF(350000));
            Console.WriteLine("Gratuity in WellsFargo:"+w1.gratuityAmount(10, 55000));
            Console.WriteLine("Leave Details in WellsFargo:"+w1.LeaveDetails());
        }
    }
    
}
