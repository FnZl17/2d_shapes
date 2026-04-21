namespace _2d_shapes
{
    partial class FrmRectangulo
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
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblProceso = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalid = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetroResult = new System.Windows.Forms.Label();
            this.lblAreaResult = new System.Windows.Forms.Label();
            this.lblTituloGrafico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(27, 39);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(71, 16);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entradas. -";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(67, 84);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(67, 16);
            this.lblAncho.TabIndex = 1;
            this.lblAncho.Text = "Ancho (a):";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(67, 121);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(64, 16);
            this.lblLargo.TabIndex = 2;
            this.lblLargo.Text = "Largo (b):";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(139, 84);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 22);
            this.txtAncho.TabIndex = 3;
            this.txtAncho.TextChanged += new System.EventHandler(this.txtAncho_TextChanged);
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(139, 121);
            this.txtLargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 22);
            this.txtLargo.TabIndex = 4;
            this.txtLargo.TextChanged += new System.EventHandler(this.txtLargo_TextChanged);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(31, 177);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(61, 16);
            this.lblProceso.TabIndex = 5;
            this.lblProceso.Text = "Proceso:";
            this.lblProceso.Click += new System.EventHandler(this.lblProceso_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(32, 213);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(113, 214);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(208, 214);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 25);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalid
            // 
            this.lblSalid.AutoSize = true;
            this.lblSalid.Location = new System.Drawing.Point(31, 261);
            this.lblSalid.Name = "lblSalid";
            this.lblSalid.Size = new System.Drawing.Size(76, 16);
            this.lblSalid.TabIndex = 9;
            this.lblSalid.Text = "Resultados";
            this.lblSalid.Click += new System.EventHandler(this.lblSalid_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(31, 298);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetro.TabIndex = 10;
            this.lblPerimetro.Text = "Perimetro:";
            this.lblPerimetro.Click += new System.EventHandler(this.lblPerimetro_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(31, 334);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Area:";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // lblPerimetroResult
            // 
            this.lblPerimetroResult.AutoSize = true;
            this.lblPerimetroResult.Location = new System.Drawing.Point(109, 298);
            this.lblPerimetroResult.Name = "lblPerimetroResult";
            this.lblPerimetroResult.Size = new System.Drawing.Size(0, 16);
            this.lblPerimetroResult.TabIndex = 12;
            this.lblPerimetroResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAreaResult
            // 
            this.lblAreaResult.AutoSize = true;
            this.lblAreaResult.Location = new System.Drawing.Point(109, 334);
            this.lblAreaResult.Name = "lblAreaResult";
            this.lblAreaResult.Size = new System.Drawing.Size(0, 16);
            this.lblAreaResult.TabIndex = 13;
            this.lblAreaResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTituloGrafico
            // 
            this.lblTituloGrafico.AutoSize = true;
            this.lblTituloGrafico.Location = new System.Drawing.Point(412, 39);
            this.lblTituloGrafico.Name = "lblTituloGrafico";
            this.lblTituloGrafico.Size = new System.Drawing.Size(50, 16);
            this.lblTituloGrafico.TabIndex = 14;
            this.lblTituloGrafico.Text = "Grafico";
            this.lblTituloGrafico.Click += new System.EventHandler(this.lblTituloGrafico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 15;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 16;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloGrafico);
            this.Controls.Add(this.lblAreaResult);
            this.Controls.Add(this.lblPerimetroResult);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalid);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblEntrada);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRectangulo";
            this.Text = "Rectangulo";
            this.Load += new System.EventHandler(this.Rectangulo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmRectangulo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalid;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetroResult;
        private System.Windows.Forms.Label lblAreaResult;
        private System.Windows.Forms.Label lblTituloGrafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}