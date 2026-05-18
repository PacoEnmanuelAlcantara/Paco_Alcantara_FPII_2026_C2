namespace Calculadora
{
    partial class Calculadora
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
            display = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnProducto = new Button();
            btnDivision = new Button();
            btnLimpiarChar = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnBorrar = new Button();
            btnResultado = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btnPunto = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.BackColor = Color.FromArgb(224, 224, 224);
            display.Font = new Font("Segoe UI", 20F);
            display.Location = new Point(14, 29);
            display.Margin = new Padding(4);
            display.Multiline = true;
            display.Name = "display";
            display.RightToLeft = RightToLeft.No;
            display.Size = new Size(394, 70);
            display.TabIndex = 0;
            display.TabStop = false;
            display.Text = "0";
            display.TextAlign = HorizontalAlignment.Right;
            display.TextChanged += textBox1_TextChanged;
            display.KeyPress += display_KeyPress;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.FromArgb(157, 0, 255);
            btnSuma.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSuma.ForeColor = Color.White;
            btnSuma.Location = new Point(12, 132);
            btnSuma.Margin = new Padding(4);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(94, 93);
            btnSuma.TabIndex = 1;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += button1_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.FromArgb(157, 0, 255);
            btnResta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnResta.ForeColor = Color.White;
            btnResta.Location = new Point(114, 132);
            btnResta.Margin = new Padding(4);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(94, 93);
            btnResta.TabIndex = 2;
            btnResta.Text = "_";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += button2_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.FromArgb(157, 0, 255);
            btnProducto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnProducto.ForeColor = Color.White;
            btnProducto.Location = new Point(214, 132);
            btnProducto.Margin = new Padding(4);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(94, 93);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "*";
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += button3_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(157, 0, 255);
            btnDivision.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDivision.ForeColor = Color.White;
            btnDivision.Location = new Point(316, 132);
            btnDivision.Margin = new Padding(4);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(94, 93);
            btnDivision.TabIndex = 4;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += button4_Click;
            // 
            // btnLimpiarChar
            // 
            btnLimpiarChar.BackColor = Color.FromArgb(157, 0, 255);
            btnLimpiarChar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnLimpiarChar.ForeColor = Color.White;
            btnLimpiarChar.Location = new Point(316, 233);
            btnLimpiarChar.Margin = new Padding(4);
            btnLimpiarChar.Name = "btnLimpiarChar";
            btnLimpiarChar.Size = new Size(94, 93);
            btnLimpiarChar.TabIndex = 8;
            btnLimpiarChar.Text = "BA";
            btnLimpiarChar.UseVisualStyleBackColor = false;
            btnLimpiarChar.Click += btnLimpiarChar_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Silver;
            btn3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(214, 233);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 93);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += button6_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Silver;
            btn2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(114, 233);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 93);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Silver;
            btn1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(12, 233);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 93);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Silver;
            btn6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(214, 334);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 93);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Silver;
            btn5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(114, 334);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 93);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Silver;
            btn4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(12, 334);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 93);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(157, 0, 255);
            btnBorrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(316, 334);
            btnBorrar.Margin = new Padding(4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 93);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.FromArgb(157, 0, 255);
            btnResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnResultado.ForeColor = Color.White;
            btnResultado.Location = new Point(316, 435);
            btnResultado.Margin = new Padding(4);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(94, 196);
            btnResultado.TabIndex = 13;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += button13_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Silver;
            btn9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(214, 435);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 93);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click_1;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Silver;
            btn8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(114, 435);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 93);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click_1;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Silver;
            btn7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(12, 435);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 93);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Silver;
            btn0.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(14, 537);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.RightToLeft = RightToLeft.Yes;
            btn0.Size = new Size(192, 93);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += button17_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = Color.Silver;
            btnPunto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPunto.ForeColor = Color.White;
            btnPunto.Location = new Point(214, 537);
            btnPunto.Margin = new Padding(4);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(94, 93);
            btnPunto.TabIndex = 18;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 638);
            Controls.Add(btnPunto);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnResultado);
            Controls.Add(btnBorrar);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnLimpiarChar);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDivision);
            Controls.Add(btnProducto);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(display);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
        private Button btnSuma;
        private Button btnResta;
        private Button btnProducto;
        private Button btnDivision;
        private Button btnLimpiarChar;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnBorrar;
        private Button btnResultado;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private Button btnPunto;
    }
}
