using System.Collections.Generic;

namespace strategy_design_pattern
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}