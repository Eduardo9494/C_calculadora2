namespace Calculadora
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
            cajaResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSiete = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnCero = new Button();
            btnPunto = new Button();
            btnMultiplicar = new Button();
            btnResta = new Button();
            btnSuma = new Button();
            btnResultado = new Button();
            btnModulo = new Button();
            btnDivision = new Button();
            btnReset = new Button();
            btnBorrar = new Button();
            lblHistorial = new Label();
            SuspendLayout();
            // 
            // cajaResultado
            // 
            cajaResultado.Font = new Font("Poor Richard", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cajaResultado.Location = new Point(30, 58);
            cajaResultado.Name = "cajaResultado";
            cajaResultado.ReadOnly = true;
            cajaResultado.Size = new Size(210, 35);
            cajaResultado.TabIndex = 0;
            cajaResultado.Text = "0";
            cajaResultado.TextAlign = HorizontalAlignment.Right;
            cajaResultado.TextChanged += cajaResultado_TextChanged;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnUno.Location = new Point(30, 273);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(48, 41);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += btnUno_Click;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnDos.Location = new Point(84, 273);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(48, 41);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += btnDos_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnTres.Location = new Point(138, 273);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(48, 41);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCuatro.Location = new Point(30, 220);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(48, 41);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += btnCuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCinco.Location = new Point(84, 220);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(48, 41);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnSeis.Location = new Point(138, 220);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(48, 41);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnSiete.Location = new Point(30, 167);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(48, 41);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += btnSiete_Click;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnOcho.Location = new Point(84, 167);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(48, 41);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += btnOcho_Click;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnNueve.Location = new Point(138, 167);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(48, 41);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += btnNueve_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCero.Location = new Point(30, 326);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(102, 41);
            btnCero.TabIndex = 10;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += btnCero_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnPunto.Location = new Point(138, 326);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(48, 41);
            btnPunto.TabIndex = 11;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(192, 167);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(48, 41);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnResta.Location = new Point(192, 220);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(48, 41);
            btnResta.TabIndex = 13;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnSuma.Location = new Point(192, 273);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(48, 41);
            btnSuma.TabIndex = 14;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnResultado.Location = new Point(192, 326);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(48, 41);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnModulo
            // 
            btnModulo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnModulo.Location = new Point(30, 114);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(48, 41);
            btnModulo.TabIndex = 16;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = true;
            btnModulo.Click += btnModulo_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnDivision.Location = new Point(84, 114);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(48, 41);
            btnDivision.TabIndex = 17;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnReset.Location = new Point(138, 114);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(48, 41);
            btnReset.TabIndex = 18;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnBorrar.Location = new Point(192, 114);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(48, 41);
            btnBorrar.TabIndex = 19;
            btnBorrar.Text = "<";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(28, 25);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(0, 15);
            lblHistorial.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 430);
            Controls.Add(lblHistorial);
            Controls.Add(btnBorrar);
            Controls.Add(btnReset);
            Controls.Add(btnDivision);
            Controls.Add(btnModulo);
            Controls.Add(btnResultado);
            Controls.Add(btnSuma);
            Controls.Add(btnResta);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(cajaResultado);
            Name = "Form1";
            Text = "Calculadora V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cajaResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSiete;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnCero;
        private Button btnPunto;
        private Button btnMultiplicar;
        private Button btnResta;
        private Button btnSuma;
        private Button btnResultado;
        private Button btnModulo;
        private Button btnDivision;
        private Button btnReset;
        private Button btnBorrar;
        private Label lblHistorial;
    }
}