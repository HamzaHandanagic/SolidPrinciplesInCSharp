using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_LSP
{
    /// <summary>
    /// Here we have everything employee has and GeneratePerformanceReview which all Employees don't have.
    /// </summary>
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
