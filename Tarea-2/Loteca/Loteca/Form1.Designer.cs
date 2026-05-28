namespace Loteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnJugar = new Button();
            txtJugado = new TextBox();
            txtApostado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnNuevaJugada = new Button();
            txtPrimera = new TextBox();
            txtTercera = new TextBox();
            txtSegunda = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtObtenido = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Blue;
            btnJugar.FlatAppearance.BorderSize = 5;
            btnJugar.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugar.ForeColor = Color.White;
            btnJugar.Location = new Point(53, 235);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(512, 57);
            btnJugar.TabIndex = 13;
            btnJugar.Text = "¡JUGAR!";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // txtJugado
            // 
            txtJugado.BorderStyle = BorderStyle.None;
            txtJugado.Font = new Font("Segoe UI", 13.8F);
            txtJugado.Location = new Point(322, 156);
            txtJugado.MaxLength = 2;
            txtJugado.Multiline = true;
            txtJugado.Name = "txtJugado";
            txtJugado.PlaceholderText = "00";
            txtJugado.Size = new Size(202, 40);
            txtJugado.TabIndex = 12;
            txtJugado.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApostado
            // 
            txtApostado.BorderStyle = BorderStyle.None;
            txtApostado.Font = new Font("Segoe UI", 13.8F);
            txtApostado.Location = new Point(102, 156);
            txtApostado.Multiline = true;
            txtApostado.Name = "txtApostado";
            txtApostado.PlaceholderText = "$ 0.00";
            txtApostado.Size = new Size(202, 40);
            txtApostado.TabIndex = 11;
            txtApostado.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(322, 133);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 10;
            label3.Text = "NÚMERO JUGADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(102, 133);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 9;
            label2.Text = "DINERO APOSTADO";
            // 
            // btnNuevaJugada
            // 
            btnNuevaJugada.BackColor = Color.FromArgb(208, 207, 245);
            btnNuevaJugada.FlatAppearance.BorderSize = 0;
            btnNuevaJugada.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaJugada.ForeColor = Color.FromArgb(46, 66, 205);
            btnNuevaJugada.Location = new Point(354, 25);
            btnNuevaJugada.Name = "btnNuevaJugada";
            btnNuevaJugada.Size = new Size(211, 45);
            btnNuevaJugada.TabIndex = 7;
            btnNuevaJugada.Text = "NUEVA JUGADA";
            btnNuevaJugada.UseVisualStyleBackColor = false;
            btnNuevaJugada.Click += btnNuevaJugada_Click;
            // 
            // txtPrimera
            // 
            txtPrimera.BackColor = Color.White;
            txtPrimera.BorderStyle = BorderStyle.None;
            txtPrimera.Font = new Font("Segoe UI", 13.8F);
            txtPrimera.Location = new Point(77, 353);
            txtPrimera.Multiline = true;
            txtPrimera.Name = "txtPrimera";
            txtPrimera.PlaceholderText = "--";
            txtPrimera.ReadOnly = true;
            txtPrimera.Size = new Size(125, 40);
            txtPrimera.TabIndex = 14;
            txtPrimera.TabStop = false;
            txtPrimera.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTercera
            // 
            txtTercera.BackColor = Color.White;
            txtTercera.BorderStyle = BorderStyle.None;
            txtTercera.Font = new Font("Segoe UI", 13.8F);
            txtTercera.Location = new Point(391, 353);
            txtTercera.Multiline = true;
            txtTercera.Name = "txtTercera";
            txtTercera.PlaceholderText = "--";
            txtTercera.ReadOnly = true;
            txtTercera.Size = new Size(125, 40);
            txtTercera.TabIndex = 15;
            txtTercera.TabStop = false;
            txtTercera.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSegunda
            // 
            txtSegunda.BackColor = Color.White;
            txtSegunda.BorderStyle = BorderStyle.None;
            txtSegunda.Font = new Font("Segoe UI", 13.8F);
            txtSegunda.Location = new Point(234, 353);
            txtSegunda.Multiline = true;
            txtSegunda.Name = "txtSegunda";
            txtSegunda.PlaceholderText = "--";
            txtSegunda.ReadOnly = true;
            txtSegunda.Size = new Size(125, 40);
            txtSegunda.TabIndex = 16;
            txtSegunda.TabStop = false;
            txtSegunda.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(100, 330);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 17;
            label4.Text = "PRIMERA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(256, 330);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 18;
            label5.Text = "SEGUNDA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(417, 330);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 19;
            label6.Text = "TERCERA";
            // 
            // txtObtenido
            // 
            txtObtenido.BackColor = Color.White;
            txtObtenido.BorderStyle = BorderStyle.None;
            txtObtenido.Font = new Font("Segoe UI", 13.8F);
            txtObtenido.Location = new Point(155, 467);
            txtObtenido.Multiline = true;
            txtObtenido.Name = "txtObtenido";
            txtObtenido.PlaceholderText = "$ 0.00";
            txtObtenido.ReadOnly = true;
            txtObtenido.Size = new Size(308, 40);
            txtObtenido.TabIndex = 20;
            txtObtenido.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(236, 433);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 21;
            label7.Text = "PREMIO OBTENIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 78);
            label1.TabIndex = 22;
            label1.Text = "Banca Express";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 57);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 23;
            label8.Text = "Control de Jugadas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 530);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(txtObtenido);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtSegunda);
            Controls.Add(txtPrimera);
            Controls.Add(btnJugar);
            Controls.Add(txtJugado);
            Controls.Add(txtApostado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNuevaJugada);
            Controls.Add(txtTercera);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Loteka";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJugar;
        private TextBox txtJugado;
        private TextBox txtApostado;
        private Label label3;
        private Label label2;
        private Button btnNuevaJugada;
        private TextBox txtPrimera;
        private TextBox txtTercera;
        private TextBox txtSegunda;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtObtenido;
        private Label label7;
        private Label label1;
        private Label label8;
    }
}
