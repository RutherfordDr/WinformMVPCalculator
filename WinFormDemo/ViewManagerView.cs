using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormDemo
{
    /// <summary>
    /// This class is a form acting as a ViewManager. It will display the three view options 
    /// (Basic, Scientific, History), and delegate the onClick methods for those three buttons 
    /// to display the other views. It has a presenter to handle the onClick methods logic, but 
    /// does not need a model.
    /// </summary>
    public partial class ViewManagerView : Form, IViewManagerView
    {
        private ViewManagerPresenter vmvPresenter = null;

        /*
         * Constructor for ViewManagerView
         */
        public ViewManagerView()
        {
            InitializeComponent();
            vmvPresenter = new ViewManagerPresenter(this);
        }

        public IBasicCalculatorView bcCalculator
        {
            get
            {
                return (IBasicCalculatorView) this.BasicCalculatorController;
            }
        }
        // TODO:
        public UserControl scCalculator
        {
            get
            {
                return null;
            }
        }
        // TODO:
        public UserControl History
        {
            get
            {
                return null;
            }
        }

        private void HandleState(object sender, EventArgs e)
        {
            var button = (Button)sender;
            vmvPresenter.ChangeState(button.Text);
        }

        private void BasicCalculatorController_Load(object sender, EventArgs e)
        {

        }
    }
}
