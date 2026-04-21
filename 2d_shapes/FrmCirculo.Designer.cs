namespace _2d_shapes
{
    partial class FrmCirculo
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Entradas = new System.Windows.Forms.Label();
            this.lbl_Radio = new System.Windows.Forms.Label();
            this.txt_Radio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAreaResult = new System.Windows.Forms.Label();
            this.lblPerimetroResult = new System.Windows.Forms.Label();
            this.lblAreaT = new System.Windows.Forms.Label();
            this.lblPerimetroT = new System.Windows.Forms.Label();
            this.lblSalidaT = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lbl_grafico = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Entradas
            // 
            this.lbl_Entradas.AutoSize = true;
            this.lbl_Entradas.Location = new System.Drawing.Point(48, 40);
            this.lbl_Entradas.Name = "lbl_Entradas";
            this.lbl_Entradas.Size = new System.Drawing.Size(64, 16);
            this.lbl_Entradas.TabIndex = 0;
            this.lbl_Entradas.Text = "Entradas:";
            // 
            // lbl_Radio
            // 
            this.lbl_Radio.AutoSize = true;
            this.lbl_Radio.Location = new System.Drawing.Point(58, 85);
            this.lbl_Radio.Name = "lbl_Radio";
            this.lbl_Radio.Size = new System.Drawing.Size(65, 16);
            this.lbl_Radio.TabIndex = 1;
            this.lbl_Radio.Text = "Radio (r): ";
            // 
            // txt_Radio
            // 
            this.txt_Radio.Location = new System.Drawing.Point(126, 85);
            this.txt_Radio.Name = "txt_Radio";
            this.txt_Radio.Size = new System.Drawing.Size(100, 22);
            this.txt_Radio.TabIndex = 2;
            this.txt_Radio.TextChanged += new System.EventHandler(this.txt_Radio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 37;
            // 
            // lblAreaResult
            // 
            this.lblAreaResult.AutoSize = true;
            this.lblAreaResult.Location = new System.Drawing.Point(130, 306);
            this.lblAreaResult.Name = "lblAreaResult";
            this.lblAreaResult.Size = new System.Drawing.Size(0, 16);
            this.lblAreaResult.TabIndex = 36;
            // 
            // lblPerimetroResult
            // 
            this.lblPerimetroResult.AutoSize = true;
            this.lblPerimetroResult.Location = new System.Drawing.Point(130, 270);
            this.lblPerimetroResult.Name = "lblPerimetroResult";
            this.lblPerimetroResult.Size = new System.Drawing.Size(0, 16);
            this.lblPerimetroResult.TabIndex = 35;
            // 
            // lblAreaT
            // 
            this.lblAreaT.AutoSize = true;
            this.lblAreaT.Location = new System.Drawing.Point(52, 306);
            this.lblAreaT.Name = "lblAreaT";
            this.lblAreaT.Size = new System.Drawing.Size(39, 16);
            this.lblAreaT.TabIndex = 34;
            this.lblAreaT.Text = "Area:";
            // 
            // lblPerimetroT
            // 
            this.lblPerimetroT.AutoSize = true;
            this.lblPerimetroT.Location = new System.Drawing.Point(52, 270);
            this.lblPerimetroT.Name = "lblPerimetroT";
            this.lblPerimetroT.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetroT.TabIndex = 33;
            this.lblPerimetroT.Text = "Perimetro:";
            // 
            // lblSalidaT
            // 
            this.lblSalidaT.AutoSize = true;
            this.lblSalidaT.Location = new System.Drawing.Point(52, 233);
            this.lblSalidaT.Name = "lblSalidaT";
            this.lblSalidaT.Size = new System.Drawing.Size(76, 16);
            this.lblSalidaT.TabIndex = 32;
            this.lblSalidaT.Text = "Resultados";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(215, 186);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 25);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(133, 185);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(53, 185);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(52, 149);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(61, 16);
            this.lblProceso.TabIndex = 28;
            this.lblProceso.Text = "Proceso:";
            // 
            // lbl_grafico
            // 
            this.lbl_grafico.AutoSize = true;
            this.lbl_grafico.Location = new System.Drawing.Point(360, 30);
            this.lbl_grafico.Name = "lbl_grafico";
            this.lbl_grafico.Size = new System.Drawing.Size(50, 16);
            this.lbl_grafico.TabIndex = 39;
            this.lbl_grafico.Text = "Gráfico";
            this.lbl_grafico.Click += new System.EventHandler(this.label3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.Location = new System.Drawing.Point(57, 347);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(0, 16);
            this.lblMensajeError.TabIndex = 40;
            // 
            // FrmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.lbl_grafico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAreaResult);
            this.Controls.Add(this.lblPerimetroResult);
            this.Controls.Add(this.lblAreaT);
            this.Controls.Add(this.lblPerimetroT);
            this.Controls.Add(this.lblSalidaT);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.txt_Radio);
            this.Controls.Add(this.lbl_Radio);
            this.Controls.Add(this.lbl_Entradas);
            this.Name = "FrmCirculo";
            this.Text = "Circulo";
            this.Load += new System.EventHandler(this.FrmCirculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Entradas;
        private System.Windows.Forms.Label lbl_Radio;
        private System.Windows.Forms.TextBox txt_Radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAreaResult;
        private System.Windows.Forms.Label lblPerimetroResult;
        private System.Windows.Forms.Label lblAreaT;
        private System.Windows.Forms.Label lblPerimetroT;
        private System.Windows.Forms.Label lblSalidaT;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lbl_grafico;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblMensajeError;
    }
}