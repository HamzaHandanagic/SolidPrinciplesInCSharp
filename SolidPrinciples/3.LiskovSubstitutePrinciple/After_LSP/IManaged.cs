using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_LSP
{
    /// <summary>
    /// Contains AssignManager method
    /// </summary>
    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}
