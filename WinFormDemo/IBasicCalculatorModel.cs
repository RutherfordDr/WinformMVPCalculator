using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDemo
{
    /// <summary>
    ///     Interface of the calculator model.
    /// </summary>
    public interface IBasicCalculatorModel
    {
        string equation
        {
            get;
            set;
        }
        string Update(string value);
        string Solve(string equation);
    }
}
