using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDemo
{
    /// <summary>
    ///     Interface for the BasicCalculator View. 
    /// </summary>
    public interface IBasicCalculatorView
    {
        string UserInputTextValue { get; set; }
        string EquationLabelValue { get; set; }
        void ShowUserController();
        void HideUserController();

    }
}
