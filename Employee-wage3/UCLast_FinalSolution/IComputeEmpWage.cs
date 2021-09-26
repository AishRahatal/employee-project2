using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Employee_wage2.UCLast_FinalSolution
{
    public interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }
}
