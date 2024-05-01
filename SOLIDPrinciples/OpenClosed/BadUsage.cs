using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClosedBadUsage
{
    public enum SalaryType
    {
        Low,
        Medium,
        High
    }

    public class SalaryCalculator
    {

        public decimal Calculate(decimal salary, SalaryType salaryType)
        {
            decimal newSalary = 0;

            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 2;
                    break;
                case SalaryType.Medium:
                    newSalary = salary * 4;
                    break;
                case SalaryType.High:
                    newSalary = salary * 6;
                    break;
                default:
                    break;
            }

            return newSalary;
        }

    }
    /*
     * Burada yeni bir maaş tipi geldiği zaman switch case'e yeni bir koşul eklemek gerekiyor bu da Open-Closed prensibini ihlal etmemiz anlamına geliyor.
     * Sadece yeni bir maaş tipi de değil, hesaplamalarda da bir değişiklik olabilir o yüzden bu metodun bu değişikliklere adapte olacak bir yapıya getirmemiz gerekiyor.
     */
}
