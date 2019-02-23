using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region basic vars
        double FirstNum = 0; // remember 1st number
        string Operatoin = ""; //remember an operator
        bool OperationPressed = false; // operation check

        #endregion

        #region Form and Text/Label Boxes
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void labelInput_Click(object sender, EventArgs e)
        {

        }

        private void infoText_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region delete buttons  | DONE
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            deleteBtn();
        }
        #endregion

        #region numbers 0-9 and "."
        private void numbers(object sender, EventArgs e)
        {
            if((textBox.Text == "0")|| OperationPressed)
            {
                textBox.Clear();
            }
            OperationPressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += b.Text;
                }
            }
            else
            {
                textBox.Text += b.Text;
                labelInput.Text += b.Text;
            }
        }
        #endregion

        #region operators

        /// <summary>
        /// operators + - * / %
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Operatoin = b.Text;
            FirstNum = double.Parse(textBox.Text);
            textBox.Text = b.Text;
            OperationPressed = true;
            labelInput.Text = FirstNum + " " + Operatoin + " ";
        }
        #endregion

        #region answer button
        private void answer_Click(object sender, EventArgs e)
        {
            labelInput.Text = "";

            switch (Operatoin)
            {

                case "+":
                    textBox.Text = (FirstNum + double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (FirstNum - double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (FirstNum * double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = ((FirstNum) / (double.Parse(textBox.Text))).ToString();
                    break;
                case "%":
                    textBox.Text = (((FirstNum) / 100)*(double.Parse(textBox.Text))).ToString();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Functions

        /// <summary>
        /// delete last char   | DONE
        /// </summary>
        private void deleteBtn()
        {
            var selectionStart = textBox.SelectionStart;
            try
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                labelInput.Text = labelInput.Text.Remove(labelInput.Text.Length - 1);
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
    }
}
