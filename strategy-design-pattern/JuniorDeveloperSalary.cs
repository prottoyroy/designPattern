using System.Collections.Generic;
using System.Linq;

namespace strategy_design_pattern
{
    public class JuniorDeveloperSalary : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) => 
        reports
            .Where(r => r.Level == DeveloperLevel.Junior)
            .Select(r => r.CalculateSalary())
            .Sum();
       
    }
    public class SeniorDevSalaryCalculator : ISalaryCalculator
{
    public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
        reports
            .Where(r => r.Level == DeveloperLevel.Senior)
            .Select(r => r.CalculateSalary() * 1.2)
            .Sum();
}

public class SalaryCalculator
{
    private ISalaryCalculator _calculator;
    public SalaryCalculator(ISalaryCalculator calculator)
    {
        _calculator = calculator;
    }
    public void SetCalculator(ISalaryCalculator calculator) => _calculator = calculator;
    public double Calculate(IEnumerable<DeveloperReport> reports) => _calculator.CalculateTotalSalary(reports);
}

}