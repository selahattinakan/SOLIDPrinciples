﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClosedGoodUsage
{

    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }

    public class ManagerSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 8;
        }
    }


    public class SalaryCalculator
    {

        public decimal Calculate(decimal salary, ISalaryCalculate salaryCalculate)
        {
            return salaryCalculate.Calculate(salary);
        }

    }
}
