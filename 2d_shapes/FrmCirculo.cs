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
    public partial class FrmCirculo : Form
    {
        private CirculoGrafico _micirculoGrafico;
        private readonly Pen _lapiz = new Pen(Color.Black, 2);
        public FrmCirculo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _micirculoGrafico = new CirculoGrafico(500, 200);
        }
        
        private void ActualizarDibujo()
        {
            _micirculoGrafico.Radio = txt_Radio.Text.ValidarNumero().AsegurarMinimo(0);
            lblMensajeError.Text = txt_Radio.Text.ReportarError("Radio");
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _micirculoGrafico.Dibujar(e.Graphics, _lapiz);
        }
        private void FrmCirculo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double areaCirculo=_micirculoGrafico.CalcularArea();
            lblAreaResult.Text = areaCirculo.ToString("F2");
            double perimetroCirculo = _micirculoGrafico.Calcularperimetro();
            lblPerimetroResult.Text= perimetroCirculo.ToString("F2");
            lblMensajeError.Text=txt_Radio.Text.ReportarError("Radio");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txt_Radio.Clear();
            ActualizarDibujo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Radio_TextChanged(object sender, EventArgs e)
        {
            ActualizarDibujo();
        }
    }
}
