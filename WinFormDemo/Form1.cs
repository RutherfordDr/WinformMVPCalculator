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
    /// This is the View. It is responsible for displaying the data and taking in user 
    /// commands.
    /// </summary>
    public partial class Form1 : Form, IView
    {
        private Presenter presenter = null;
        private readonly Model m_Model;
        /*
         * Constructor for Form1.
         */
        public Form1(Model model)
        {
            m_Model = model;
            InitializeComponent();
            presenter = new Presenter(this, m_Model);
        }

        // Getter/Setter for UserInputTextValue. This corresponds to the forms UserInputText object.
        public string UserInputTextValue
        {
            get
            {
                return UserInputText.Text;
            }
            set
            {
                UserInputText.Text = value;
            }
        }
        // Getter/Setter for EquationLabelValue. This corresponds to the forms EquationLable object.
        public string EquationLabelValue
        {
            get
            {
                return EquationLabel.Text;
            }
            set
            {
                EquationLabel.Text = value;
            }
        }
        
        /*
         * 
         */
        private void equalsButton_Click(object sender, EventArgs e)
        {
            presenter.UpdateEquation(this.UserInputText.Text);
            presenter.SolveEquation();
        }
        
        /*
         *  Refactor to send to presenter
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = String.Empty;
        }
       
        /*
         * 
         */
        private void numberButton_Click(object sender, EventArgs e)
        {
            var button = (Button) sender;
            this.UserInputText.Text += button.Text;
        }
        
        /*
         * 
         */
        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.Text != string.Empty)
            {
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.Text.Length - 1);
            }
            
            //presenter.backspace
        }
       

        
    }
}
