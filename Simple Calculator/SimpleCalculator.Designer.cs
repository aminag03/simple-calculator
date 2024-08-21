namespace Simple_Calculator
{
    partial class SimpleCalculator
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
            txtResult = new TextBox();
            btnEquals = new Button();
            btnDeleteLastInput = new Button();
            btnDelete = new Button();
            btnRemoveLastDigit = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMinus = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnSign = new Button();
            btn0 = new Button();
            btnDecimalPoint = new Button();
            btnPlus = new Button();
            lblCache = new Label();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Enabled = false;
            txtResult.Font = new Font("Segoe UI", 25F);
            txtResult.Location = new Point(13, 38);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(336, 70);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.GrayText;
            btnEquals.Font = new Font("Segoe UI", 20F);
            btnEquals.ForeColor = SystemColors.ControlLightLight;
            btnEquals.Location = new Point(12, 114);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(79, 79);
            btnEquals.TabIndex = 2;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDeleteLastInput
            // 
            btnDeleteLastInput.BackColor = SystemColors.ControlLight;
            btnDeleteLastInput.Font = new Font("Segoe UI", 20F);
            btnDeleteLastInput.Location = new Point(97, 114);
            btnDeleteLastInput.Name = "btnDeleteLastInput";
            btnDeleteLastInput.Size = new Size(79, 79);
            btnDeleteLastInput.TabIndex = 3;
            btnDeleteLastInput.Text = "CE";
            btnDeleteLastInput.UseVisualStyleBackColor = false;
            btnDeleteLastInput.Click += btnDeleteLastInput_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(182, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 79);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRemoveLastDigit
            // 
            btnRemoveLastDigit.BackColor = SystemColors.ControlLight;
            btnRemoveLastDigit.Font = new Font("Segoe UI", 20F);
            btnRemoveLastDigit.Location = new Point(269, 114);
            btnRemoveLastDigit.Name = "btnRemoveLastDigit";
            btnRemoveLastDigit.Size = new Size(79, 79);
            btnRemoveLastDigit.TabIndex = 5;
            btnRemoveLastDigit.Text = "⌫";
            btnRemoveLastDigit.UseVisualStyleBackColor = false;
            btnRemoveLastDigit.Click += btnRemoveLastDigit_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 20F);
            btn3.Location = new Point(182, 199);
            btn3.Name = "btn3";
            btn3.Size = new Size(79, 79);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 20F);
            btn4.Location = new Point(13, 284);
            btn4.Name = "btn4";
            btn4.Size = new Size(79, 79);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 20F);
            btn5.Location = new Point(97, 284);
            btn5.Name = "btn5";
            btn5.Size = new Size(79, 79);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 20F);
            btn6.Location = new Point(182, 284);
            btn6.Name = "btn6";
            btn6.Size = new Size(79, 79);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ControlLight;
            btnMultiply.Font = new Font("Segoe UI", 20F);
            btnMultiply.Location = new Point(270, 284);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(79, 79);
            btnMultiply.TabIndex = 10;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ControlLight;
            btnDivide.Font = new Font("Segoe UI", 20F);
            btnDivide.Location = new Point(270, 199);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(79, 79);
            btnDivide.TabIndex = 11;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 20F);
            btn2.Location = new Point(97, 199);
            btn2.Name = "btn2";
            btn2.Size = new Size(79, 79);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 20F);
            btn1.Location = new Point(13, 199);
            btn1.Name = "btn1";
            btn1.Size = new Size(79, 79);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ControlLight;
            btnMinus.Font = new Font("Segoe UI", 20F);
            btnMinus.Location = new Point(270, 369);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(79, 79);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 20F);
            btn9.Location = new Point(183, 369);
            btn9.Name = "btn9";
            btn9.Size = new Size(79, 79);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 20F);
            btn8.Location = new Point(98, 369);
            btn8.Name = "btn8";
            btn8.Size = new Size(79, 79);
            btn8.TabIndex = 16;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 20F);
            btn7.Location = new Point(13, 369);
            btn7.Name = "btn7";
            btn7.Size = new Size(79, 79);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("Segoe UI", 20F);
            btnSign.Location = new Point(13, 454);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(79, 79);
            btnSign.TabIndex = 21;
            btnSign.Text = "±";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 20F);
            btn0.Location = new Point(98, 454);
            btn0.Name = "btn0";
            btn0.Size = new Size(79, 79);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.Font = new Font("Segoe UI", 20F);
            btnDecimalPoint.Location = new Point(183, 454);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(79, 79);
            btnDecimalPoint.TabIndex = 19;
            btnDecimalPoint.Text = ",";
            btnDecimalPoint.UseVisualStyleBackColor = true;
            btnDecimalPoint.Click += btnDecimalPoint_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ControlLight;
            btnPlus.Font = new Font("Segoe UI", 20F);
            btnPlus.Location = new Point(270, 454);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(79, 79);
            btnPlus.TabIndex = 18;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // lblCache
            // 
            lblCache.AutoSize = true;
            lblCache.Dock = DockStyle.Right;
            lblCache.ForeColor = SystemColors.ControlDarkDark;
            lblCache.Location = new Point(360, 0);
            lblCache.Name = "lblCache";
            lblCache.Size = new Size(0, 20);
            lblCache.TabIndex = 22;
            lblCache.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 545);
            Controls.Add(lblCache);
            Controls.Add(btnSign);
            Controls.Add(btn0);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btnPlus);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMinus);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btnRemoveLastDigit);
            Controls.Add(btnDelete);
            Controls.Add(btnDeleteLastInput);
            Controls.Add(btnEquals);
            Controls.Add(txtResult);
            KeyPreview = true;
            Name = "SimpleCalculator";
            Text = "Calculator";
            KeyPress += SimpleCalculator_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnEquals;
        private Button btnDeleteLastInput;
        private Button btnDelete;
        private Button btnRemoveLastDigit;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btn2;
        private Button btn1;
        private Button btnMinus;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnSign;
        private Button btn0;
        private Button btnDecimalPoint;
        private Button btnPlus;
        private Label lblCache;
    }
}
