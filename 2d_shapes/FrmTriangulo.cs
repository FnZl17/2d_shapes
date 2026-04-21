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
    public partial class FrmTriangulo : Form
    {
        private TrianguloGrafico _miTriangulo;
        private readonly Pen _lapiz = new Pen(Color.Red, 2);

        public FrmTriangulo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _miTriangulo = new TrianguloGrafico(400, 400);
        }
        private void ActualizarDibujo()
        {
            _miTriangulo.LadoA = txtLado1.Text.ValidarNumero().AsegurarMinimo(0);
            _miTriangulo.LadoB = txtLado2.Text.ValidarNumero().AsegurarMinimo(0);
            _miTriangulo.LadoC = txtLado3.Text.ValidarNumero().AsegurarMinimo(0);
            lblMensajeError.Text = txtLado1.Text.ReportarError("Lado 1") + txtLado2.Text.ReportarError("Lado 2") + txtLado3.Text.ReportarError("Lado 3");
            this.Invalidate();
        }
        private void lblEntrada_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
            ActualizarDibujo();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _miTriangulo.Dibujar(e.Graphics, _lapiz);
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {
            ActualizarDibujo();
        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {
            ActualizarDibujo();
        }
        private void txtLado3_TextChanged(object sender, EventArgs e)
        {
            ActualizarDibujo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double areaTriangulo = _miTriangulo.CalcularArea();
            lblAreaResult.Text = areaTriangulo.ToString("F2");
            double perimetroTriangulo = _miTriangulo.CalcularPerimetro();
            lblPerimetroResult.Text = perimetroTriangulo.ToString("F2");
            lblMensajeError.Text = txtLado1.Text.ReportarError("Lado 1") + txtLado2.Text.ReportarError("Lado 2") + txtLado3.Text.ReportarError("Lado 3");

        }
    }

}