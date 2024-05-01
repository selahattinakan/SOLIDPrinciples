using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClosedGoodUsage2
{
    public class LowSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }

    public class ManagerSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 8;
        }
    }


    public class SalaryCalculator
    {

        //Delegeler
        //Action => void
        //Predicate => bool
        //Function

        public decimal Calculate(decimal salary, Func<decimal,decimal> calculateDelegate)
        {
            return calculateDelegate(salary);
        }

    }

    /*Best Practice for Open Closed*/
}
