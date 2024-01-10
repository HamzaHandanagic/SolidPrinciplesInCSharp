using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_LSP
{
    /// <summary>
    /// Inherit common and managed things.
    /// </summary>
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }
    }
}
