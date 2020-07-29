using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDemo
{
    public interface IModel
    {
        string equation
        {
            get;
            set;
        }
        string Set(string value);
        string Update(string value);

        string Solve(string equation);
    }
}
