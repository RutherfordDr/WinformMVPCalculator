using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDemo
{
    public interface IView
    {
        string UserInputTextValue { get; set; }
        string EquationLabelValue { get; set; }
    }
}
