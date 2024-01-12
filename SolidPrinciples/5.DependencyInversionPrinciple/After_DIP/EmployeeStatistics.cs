using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_DIP
{
    /// <summary>
    /// Now, our EmployeeStatistics class is not dependent on the lower-level class. We are injecting interface instead. 
    /// EmployeeManager class can change its behavior about storing employees as well.
    /// </summary>
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;
        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }
        public int CountFemaleManagers() =>
        _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
