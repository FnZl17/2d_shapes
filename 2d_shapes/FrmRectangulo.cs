using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2d_shapes.Validaciones;
using _2d_shapes.logica;

namespace _2d_shapes
    {

        public partial class FrmRectangulo : Form
        {
            private RectanguloGrafico _miRectangulo;
            private readonly Pen _lapiz = new Pen(Color.Blue, 2);

            public FrmRectangulo()
            {
                InitializeComponent();

                this.DoubleBuffered = true;
                _miRectangulo = new RectanguloGrafico(289, 58);
            }

            private void ActualizarDibujo()
            {
                _miRectangulo.Ancho = txtAncho.Text.ValidarNumero().AsegurarMinimo(0);  
            _miRectangulo.Largo = txtLargo.Text.ValidarNumero().AsegurarMinimo(0);
            lblMensajeError.Text = txtAncho.Text.ReportarError("Ancho") + txtLargo.Text.ReportarError("Largo");
            this.Invalidate();
            }


            private void Rectangulo_Load(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }
        private void FrmRectangulo_Paint(object sender, PaintEventArgs e)
        {




        }

        protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                _miRectangulo.Dibujar(e.Graphics, _lapiz);
            }

            private void txtAncho_TextChanged(object sender, EventArgs e)
            {
                ActualizarDibujo();
            }
            private void txtLargo_TextChanged(object sender, EventArgs e)
            {
                ActualizarDibujo();
            }

            private void btnBorrar_Click(object sender, EventArgs e)
            {
                txtAncho.Clear();
                txtLargo.Clear();
                ActualizarDibujo();
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void lblTituloGrafico_Click(object sender, EventArgs e)
            {

            }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resArea = _miRectangulo.CalcularArea();
            lblAreaResult.Text= resArea.ToString("F2");

            double resPerimetro =_miRectangulo.CalcularPerimetro();
            lblPerimetroResult.Text = resPerimetro.ToString("F2");

            lblMensajeError.Text = txtAncho.Text.ReportarError("Ancho") + txtLargo.Text.ReportarError("Largo");

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void lblSalid_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblProceso_Click(object sender, EventArgs e)
        {

        }
    }

    }
