namespace ScientificCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            txtHistory = new TextBox();
            button1 = new Button();
            btnMode = new Button();
            button3 = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            btnDivide = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            button26 = new Button();
            btnAdd = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            button31 = new Button();
            btnEquals = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            button36 = new Button();
            button37 = new Button();
            button38 = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.ActiveCaptionText;
            txtDisplay.Font = new Font("Segoe UI", 24F);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(217, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(229, 50);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // txtHistory
            // 
            txtHistory.BackColor = SystemColors.ActiveCaptionText;
            txtHistory.ForeColor = Color.LightSlateGray;
            txtHistory.Location = new Point(217, 59);
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(229, 23);
            txtHistory.TabIndex = 1;
            txtHistory.Text = "Empty";
            txtHistory.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(217, 88);
            button1.Name = "button1";
            button1.Size = new Size(41, 23);
            button1.TabIndex = 2;
            button1.Text = "2nd";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMode
            // 
            btnMode.BackColor = SystemColors.MenuHighlight;
            btnMode.Location = new Point(264, 88);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(41, 23);
            btnMode.TabIndex = 3;
            btnMode.Text = "\tπ";
            btnMode.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Location = new Point(311, 88);
            button3.Name = "button3";
            button3.Size = new Size(41, 23);
            button3.TabIndex = 4;
            button3.Text = "e";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GrayText;
            btnClear.Location = new Point(358, 88);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(41, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.MenuHighlight;
            btnBackspace.Location = new Point(405, 88);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(41, 23);
            btnBackspace.TabIndex = 6;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Info;
            button6.Location = new Point(405, 117);
            button6.Name = "button6";
            button6.Size = new Size(41, 23);
            button6.TabIndex = 11;
            button6.Text = "∛x";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Info;
            button7.Location = new Point(358, 117);
            button7.Name = "button7";
            button7.Size = new Size(41, 23);
            button7.TabIndex = 10;
            button7.Text = "\t√x";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ScrollBar;
            button8.Location = new Point(311, 117);
            button8.Name = "button8";
            button8.Size = new Size(41, 23);
            button8.TabIndex = 9;
            button8.Text = "\tx³";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ScrollBar;
            button9.Location = new Point(264, 117);
            button9.Name = "button9";
            button9.Size = new Size(41, 23);
            button9.TabIndex = 8;
            button9.Text = "1/x";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ScrollBar;
            button10.Location = new Point(217, 117);
            button10.Name = "button10";
            button10.Size = new Size(41, 23);
            button10.TabIndex = 7;
            button10.Text = "\tx²";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Info;
            button11.Location = new Point(405, 146);
            button11.Name = "button11";
            button11.Size = new Size(41, 23);
            button11.TabIndex = 16;
            button11.Text = "ln";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Info;
            button12.Location = new Point(358, 146);
            button12.Name = "button12";
            button12.Size = new Size(41, 23);
            button12.TabIndex = 15;
            button12.Text = "log";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ScrollBar;
            button13.Location = new Point(311, 146);
            button13.Name = "button13";
            button13.Size = new Size(41, 23);
            button13.TabIndex = 14;
            button13.Text = "\t2ˣ";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ScrollBar;
            button14.Location = new Point(264, 146);
            button14.Name = "button14";
            button14.Size = new Size(41, 23);
            button14.TabIndex = 13;
            button14.Text = "\t10ˣ";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ScrollBar;
            button15.Location = new Point(217, 146);
            button15.Name = "button15";
            button15.Size = new Size(41, 23);
            button15.TabIndex = 12;
            button15.Text = "\txʸ";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.Info;
            btnDivide.Location = new Point(405, 175);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(41, 23);
            btnDivide.TabIndex = 21;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.Info;
            button17.Location = new Point(358, 175);
            button17.Name = "button17";
            button17.Size = new Size(41, 23);
            button17.TabIndex = 20;
            button17.Text = "n!";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.ScrollBar;
            button18.Location = new Point(311, 175);
            button18.Name = "button18";
            button18.Size = new Size(41, 23);
            button18.TabIndex = 19;
            button18.Text = "tan";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ScrollBar;
            button19.Location = new Point(264, 175);
            button19.Name = "button19";
            button19.Size = new Size(41, 23);
            button19.TabIndex = 18;
            button19.Text = "cos";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.ScrollBar;
            button20.Location = new Point(217, 175);
            button20.Name = "button20";
            button20.Size = new Size(41, 23);
            button20.TabIndex = 17;
            button20.Text = "sin";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.Info;
            btnSubtract.Location = new Point(405, 204);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(41, 23);
            btnSubtract.TabIndex = 26;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.Info;
            btnMultiply.Location = new Point(358, 204);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(41, 23);
            btnMultiply.TabIndex = 25;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.GrayText;
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(311, 204);
            btn9.Name = "btn9";
            btn9.Size = new Size(41, 23);
            btn9.TabIndex = 24;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.GrayText;
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(264, 204);
            btn8.Name = "btn8";
            btn8.Size = new Size(41, 23);
            btn8.TabIndex = 23;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.GrayText;
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(217, 204);
            btn7.Name = "btn7";
            btn7.Size = new Size(41, 23);
            btn7.TabIndex = 22;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // button26
            // 
            button26.BackColor = SystemColors.Info;
            button26.Location = new Point(405, 233);
            button26.Name = "button26";
            button26.Size = new Size(41, 23);
            button26.TabIndex = 31;
            button26.Text = "%";
            button26.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.Location = new Point(358, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(41, 23);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.GrayText;
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(311, 233);
            btn6.Name = "btn6";
            btn6.Size = new Size(41, 23);
            btn6.TabIndex = 29;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.GrayText;
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(264, 233);
            btn5.Name = "btn5";
            btn5.Size = new Size(41, 23);
            btn5.TabIndex = 28;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.GrayText;
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(217, 233);
            btn4.Name = "btn4";
            btn4.Size = new Size(41, 23);
            btn4.TabIndex = 27;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // button31
            // 
            button31.BackColor = SystemColors.Info;
            button31.Location = new Point(405, 262);
            button31.Name = "button31";
            button31.Size = new Size(41, 23);
            button31.TabIndex = 36;
            button31.Text = "\t+/-";
            button31.UseVisualStyleBackColor = false;
            button31.Click += button31_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.Info;
            btnEquals.Location = new Point(358, 262);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(41, 23);
            btnEquals.TabIndex = 35;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.GrayText;
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(311, 262);
            btn3.Name = "btn3";
            btn3.Size = new Size(41, 23);
            btn3.TabIndex = 34;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.GrayText;
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(264, 262);
            btn2.Name = "btn2";
            btn2.Size = new Size(41, 23);
            btn2.TabIndex = 33;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.GrayText;
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(217, 262);
            btn1.Name = "btn1";
            btn1.Size = new Size(41, 23);
            btn1.TabIndex = 32;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // button36
            // 
            button36.BackColor = SystemColors.ActiveCaption;
            button36.Location = new Point(405, 291);
            button36.Name = "button36";
            button36.Size = new Size(41, 23);
            button36.TabIndex = 41;
            button36.Text = "Ans";
            button36.UseVisualStyleBackColor = false;
            button36.Click += button36_Click;
            // 
            // button37
            // 
            button37.BackColor = SystemColors.ActiveCaption;
            button37.Location = new Point(358, 291);
            button37.Name = "button37";
            button37.Size = new Size(41, 23);
            button37.TabIndex = 40;
            button37.Text = ")";
            button37.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            button38.BackColor = SystemColors.ActiveCaption;
            button38.Location = new Point(311, 291);
            button38.Name = "button38";
            button38.Size = new Size(41, 23);
            button38.TabIndex = 39;
            button38.Text = "(";
            button38.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.ActiveCaption;
            btnDecimal.Location = new Point(264, 291);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(41, 23);
            btnDecimal.TabIndex = 38;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaption;
            btn0.Location = new Point(217, 291);
            btn0.Name = "btn0";
            btn0.Size = new Size(41, 23);
            btn0.TabIndex = 37;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(634, 611);
            Controls.Add(button36);
            Controls.Add(button37);
            Controls.Add(button38);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(button31);
            Controls.Add(btnEquals);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(button26);
            Controls.Add(btnAdd);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(btnBackspace);
            Controls.Add(btnClear);
            Controls.Add(button3);
            Controls.Add(btnMode);
            Controls.Add(button1);
            Controls.Add(txtHistory);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScientificCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private TextBox txtHistory;
        private Button button1;
        private Button btnMode;
        private Button button3;
        private Button btnClear;
        private Button btnBackspace;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button btnDivide;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button button26;
        private Button btnAdd;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button button31;
        private Button btnEquals;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button button36;
        private Button button37;
        private Button button38;
        private Button btnDecimal;
        private Button btn0;
    }
}
