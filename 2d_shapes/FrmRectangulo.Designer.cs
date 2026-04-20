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
            this.lblEntrada.Location = new System.Drawing.Point(20, 32);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(58, 13);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entradas. -";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(50, 68);
            this.lblAncho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(56, 13);
            this.lblAncho.TabIndex = 1;
            this.lblAncho.Text = "Ancho (a):";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(50, 98);
            this.lblLargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(52, 13);
            this.lblLargo.TabIndex = 2;
            this.lblLargo.Text = "Largo (b):";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(104, 68);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(76, 20);
            this.txtAncho.TabIndex = 3;
            this.txtAncho.TextChanged += new System.EventHandler(this.txtAncho_TextChanged);
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(104, 98);
            this.txtLargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(76, 20);
            this.txtLargo.TabIndex = 4;
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(23, 144);
            this.lblProceso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(49, 13);
            this.lblProceso.TabIndex = 5;
            this.lblProceso.Text = "Proceso:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 173);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(56, 19);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(85, 174);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(56, 19);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(156, 174);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 20);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalid
            // 
            this.lblSalid.AutoSize = true;
            this.lblSalid.Location = new System.Drawing.Point(23, 212);
            this.lblSalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalid.Name = "lblSalid";
            this.lblSalid.Size = new System.Drawing.Size(60, 13);
            this.lblSalid.TabIndex = 9;
            this.lblSalid.Text = "Resultados";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(23, 242);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(54, 13);
            this.lblPerimetro.TabIndex = 10;
            this.lblPerimetro.Text = "Perimetro:";
            //this.lblPerimetro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(23, 271);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimetroResult
            // 
            this.lblPerimetroResult.AutoSize = true;
            this.lblPerimetroResult.Location = new System.Drawing.Point(82, 242);
            this.lblPerimetroResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetroResult.Name = "lblPerimetroResult";
            this.lblPerimetroResult.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetroResult.TabIndex = 12;
            this.lblPerimetroResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAreaResult
            // 
            this.lblAreaResult.AutoSize = true;
            this.lblAreaResult.Location = new System.Drawing.Point(82, 271);
            this.lblAreaResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaResult.Name = "lblAreaResult";
            this.lblAreaResult.Size = new System.Drawing.Size(0, 13);
            this.lblAreaResult.TabIndex = 13;
            this.lblAreaResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTituloGrafico
            // 
            this.lblTituloGrafico.AutoSize = true;
            this.lblTituloGrafico.Location = new System.Drawing.Point(309, 32);
            this.lblTituloGrafico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloGrafico.Name = "lblTituloGrafico";
            this.lblTituloGrafico.Size = new System.Drawing.Size(41, 13);
            this.lblTituloGrafico.TabIndex = 14;
            this.lblTituloGrafico.Text = "Grafico";
            this.lblTituloGrafico.Click += new System.EventHandler(this.lblTituloGrafico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // FrmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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