using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class BasicCalculatorView : UserControl, IBasicCalculatorView
    {
        private BasicCalculatorPresenter bcPresenter = null;
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
        public BasicCalculatorView()
        {
            InitializeComponent();
            BasicCalculatorModel model = new BasicCalculatorModel();
            bcPresenter = new BasicCalculatorPresenter(this, model);
        }

        
       public void ShowUserController()
        {
            Show();
        }

        public void HideUserController()
        {
            Hide();
        }
            
        /*
         * Tells presenter to update the equation and then solve the equation which also validates
         * if the equation is in the proper form.
         */
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            bcPresenter.UpdateEquation();
            bcPresenter.SolveEquation();
        }

        /*
         *  Refactor to send to presenter
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = String.Empty;
        }

        /*
         * These don't go through presenter because they are fairly simple. They update
         * the input line. The model or presenter don't need to know these are changed until
         * the user wants to solve the equation.
         */
        private void NumberButtonClick(object sender, EventArgs e)
        {
            var button = (Button) sender;
            this.UserInputText.Text += button.Text;
        }

        /*
         * See above explanation for numberButton_Click
         */
        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.Text != string.Empty)
            {
               this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.Text.Length - 1);
            }
        }

        private void UserInputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                EqualsButton_Click(sender, e);
            }
        }

        
    }
}
