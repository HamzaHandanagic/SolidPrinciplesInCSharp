using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace After_DIP
{
    /// <summary>
    /// We want is to decouple our two classes so the both of them depend on abstraction - interface.
    /// </summary>
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
