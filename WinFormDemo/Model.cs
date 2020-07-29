using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

/// <summary>
/// This is the Calculator Class. It is responsible for only taking in an equation, and outputting the 
/// answer.
/// </summary>
namespace WinFormDemo
{

    public class Model : IModel
    {
        // Getter/Setter for the answer to the prev equation.
        public double answer
        { get; set; }
        // Getter/Setter for the equation.
        public string equation
        { get; set; }
        // Constructor for the model.
        public Model()
        {

        }
        
        // Takes in a string and adds it the equation and returns the whole equation.
        public string Update(string text)
        {
            equation += text;
            return equation;
        }

        /* Assumes that a valid string representing an equation is its input. It solves it
         * according to BEDMAS and then returns it. Based off solution from LeetCode. Reformatted
         * to work with decimal numbers.
         * 
         * TODO: Does not support multiplying/dividing negative numbers.
         */
        public string Solve(string s)
        {
            // Initiate stack, set op to + because default is positive nums, and num to 0. Placeholder is for
            // dealing with decimals.
            var stack = new Stack<double>();
            bool isDecimal = false;
            int placeHolder = 1;
            char op = '+';
            double num = 0.0;
            
            for (int i = 0; i <= s.Length; i++)
            {
                // if index is not the last one then set c to the char at the index, else set c to '+'
                char c = i < s.Length ? s[i] : '+';
                if (c == '.')
                {
                    isDecimal = true;
                }
                else if (char.IsNumber(c))
                {
                    // For single digits this will turn it into a single digit. For anything larger
                    // this will make sure it keeps track of all the digits. (c - '0') turns the char to digit. 
                    if (!isDecimal)
                    {
                        num = num * 10 + (c - '0');
                    } else
                    {
                        placeHolder *= 10;
                        double dec = (double) (c - '0') / placeHolder ;
                        num += dec;
                    }
                }
                else
                {                 
                    // if its * or / then calculate and push onto stack. If +/- then push to stack.
                    if (op == '+') stack.Push(num);
                    if (op == '-') stack.Push(-num);
                    if (op == '*') stack.Push(stack.Pop() * num);
                    if (op == '/') stack.Push(stack.Pop() / num);                
                    op = c;
                    num = 0.0;
                    isDecimal = false;
                    placeHolder = 1;
                }
            }
            // Return the summed stack which will contain -/+ nums.
            return stack.Sum().ToString();
        }
    }
}


    