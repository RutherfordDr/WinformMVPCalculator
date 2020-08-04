using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace WinFormDemo
{

    /// <summary>
    ///     This is the Presenter Class. It is responsible for communicating between the view and
    ///     the model. It handles all the logic for the view, and it reformats the data so it is
    ///     presentable to the model. It updates the view after the model has done the appropriate
    ///     work with the data.
    /// </summary>
    public class BasicCalculatorPresenter
    {
        private readonly IBasicCalculatorView m_View;
        private IBasicCalculatorModel m_Model;

        /* 
         * Constructor to connect the Presenter to the View and Model which are referenced as
         * their interfaces to make unit testing easier.
         */
        public BasicCalculatorPresenter(IBasicCalculatorView view, IBasicCalculatorModel model)
        {
            this.m_View = view;
            this.m_Model = model;
        }
        
        /* 
         * Executed when equal button is clicked. It reformats the equation into the proper form,
         * and then calls on the Model to solve the equation. It then updates the label with the answer.
         */
        public void SolveEquation()
        {
            if (ValidateInput())
            {
                m_View.EquationLabelValue = m_Model.Solve(m_Model.equation);
            } else
            {
                m_View.EquationLabelValue = "Invalid input";
            }
        }

        /* 
         * Calls the model to update the equation with the string it is given.
         */
        public void UpdateEquation()
        {
            m_Model.equation = FormatInput();
        }
       
        /*
         * Checks to see if a valid equation is entered. This doesn't look pretty,
         *  but it works.
         */
        private bool ValidateInput()
        {
            List<char> opsList = new List<char>();
            opsList.Add('.');
            opsList.Add('/');
            opsList.Add('*');
            opsList.Add('+');
            // Base Cases
            if (m_Model.equation.Equals("") || m_Model.equation.Contains("/0") || m_Model.equation.Contains("/-0") 
                || opsList.Contains(m_Model.equation[0]) || opsList.Contains(m_Model.equation[m_Model.equation.Length - 1]))
            {
                return false;
            }
            else
            {
                bool prevIsNum = false;
                foreach (char c in m_Model.equation)
                {
                    if (char.IsDigit(c) || c == '-')
                    {
                        prevIsNum = true;
                    }
                    else if (opsList.Contains(c))
                    {
                        if (!prevIsNum)
                        {
                            return false;
                        }
                        prevIsNum = false;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }                        
        }
        
        /*
         * Gets rid of leading/trailing spaces and spaces inbetween nums/operators so that
         * the calculator can handle it correctly.
         */
        private string FormatInput()
        {
            string formattedInput = m_View.UserInputTextValue.Trim();
            formattedInput = formattedInput.Replace(" ", "");
            return formattedInput;
        }

        
    }
}
