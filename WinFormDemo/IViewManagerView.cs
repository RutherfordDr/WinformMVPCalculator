using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    /// <summary>
    ///     Interface for the ViewManagerView. Needs a reference of all the userControllers
    ///     thorough their interfaces.
    /// </summary>
    interface IViewManagerView
    {
        IBasicCalculatorView bcCalculator
        {
            get;
        }
        
        // Change to interfaces
        UserControl scCalculator
        {
            get;
        }
        UserControl History
        {
            get;
        }

       
    }
}
