namespace myCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.deduct = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.persent = new System.Windows.Forms.Button();
            this.dot_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(49, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(505, 31);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelInput
            // 
            this.labelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInput.Location = new System.Drawing.Point(49, 95);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(505, 31);
            this.labelInput.TabIndex = 1;
            this.labelInput.Click += new System.EventHandler(this.labelInput_Click);
            // 
            // infoText
            // 
            this.infoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoText.Location = new System.Drawing.Point(49, 157);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(505, 31);
            this.infoText.TabIndex = 2;
            this.infoText.Text = "Input values";
            this.infoText.Click += new System.EventHandler(this.infoText_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(49, 214);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(112, 92);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(182, 214);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(112, 92);
            this.buttonCE.TabIndex = 4;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(441, 214);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(112, 92);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operation_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(442, 326);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(112, 92);
            this.multiply.TabIndex = 10;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(315, 326);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 92);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numbers);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(49, 326);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 92);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numbers);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(182, 326);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 92);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numbers);
            // 
            // deduct
            // 
            this.deduct.Location = new System.Drawing.Point(442, 436);
            this.deduct.Name = "deduct";
            this.deduct.Size = new System.Drawing.Size(112, 92);
            this.deduct.TabIndex = 14;
            this.deduct.Text = "-";
            this.deduct.UseVisualStyleBackColor = true;
            this.deduct.Click += new System.EventHandler(this.operation_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(315, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 92);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numbers);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 92);
            this.button5.TabIndex = 12;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numbers);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 92);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numbers);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(442, 547);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 92);
            this.add.TabIndex = 18;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operation_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 92);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numbers);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 92);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numbers);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 92);
            this.button1.TabIndex = 15;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numbers);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(315, 658);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(239, 92);
            this.answer.TabIndex = 22;
            this.answer.Text = "=";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(49, 658);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(112, 92);
            this.button0.TabIndex = 20;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numbers);
            // 
            // persent
            // 
            this.persent.Location = new System.Drawing.Point(315, 214);
            this.persent.Name = "persent";
            this.persent.Size = new System.Drawing.Size(112, 92);
            this.persent.TabIndex = 23;
            this.persent.Text = "%";
            this.persent.UseVisualStyleBackColor = true;
            this.persent.Click += new System.EventHandler(this.operation_Click);
            // 
            // dot_btn
            // 
            this.dot_btn.Location = new System.Drawing.Point(182, 658);
            this.dot_btn.Name = "dot_btn";
            this.dot_btn.Size = new System.Drawing.Size(112, 92);
            this.dot_btn.TabIndex = 24;
            this.dot_btn.Text = ",";
            this.dot_btn.UseVisualStyleBackColor = true;
            this.dot_btn.Click += new System.EventHandler(this.numbers);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 846);
            this.Controls.Add(this.dot_btn);
            this.Controls.Add(this.persent);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deduct);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button deduct;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button persent;
        private System.Windows.Forms.Button dot_btn;
    }
}

