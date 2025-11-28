using System.Collections.Generic;

namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var employees = new List<Employee>();
            int employeeCount = employeesArray.GetLength(0);

            for (int i = 0; i < employeeCount; i++)
            {
                int id = System.Convert.ToInt32(employeesArray[i, 0]);
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                decimal salary = System.Convert.ToDecimal(employeesArray[i, 3]);

                employees.Add(new Employee(id, name, designation, salary));
            }

            _thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}