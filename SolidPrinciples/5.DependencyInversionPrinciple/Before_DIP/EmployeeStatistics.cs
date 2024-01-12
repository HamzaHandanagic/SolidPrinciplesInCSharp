using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_DIP
{    
     /// <summary>
     /// A higher-level class to perform some kind of statistical analysis on our employees.
     /// This code will work but it violates the DIP. 
     /// EmployeeStatistics class has a strong relation (coupled) to the EmployeeManager class and we can’t send any other object 
     /// in the EmployeeStatistics constructor except the EmployeeManager object. 
     /// The second problem is that we are using the public property from the low-level class inside the high-level class. 
     /// Our low-level class can’t change its way of keeping track of employees.
     /// If we want to change its behavior to use a dictionary instead of a list, we need to change the EmployeeStatistics class behavior for sure. 
     /// </summary>
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;
        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }
        public int CountFemaleManagers() =>
          _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);
    }
}
