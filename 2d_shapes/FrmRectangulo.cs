using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                _miRectangulo.Ancho = txtAncho.Text.ValidarEntero().AsegurarMinimo(1);
                _miRectangulo.Largo = txtLargo.Text.ValidarEntero().AsegurarMinimo(1);
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
            public class RectanguloGrafico
            {
                public int X { get; }
                public int Y { get; }
                public int Ancho { get; set; }
                public int Largo { get; set; }

                public RectanguloGrafico(int x, int y) { X = x; Y = y; }

                public void Dibujar(Graphics g, Pen lapiz)
                {
                    if (Ancho > 0 && Largo > 0)
                        g.DrawRectangle(lapiz, X, Y, Ancho, Largo);
                }
            }

        }

        // --- MOTOR DE VALIDACIÓN (Fluent Extensions) ---
        // Mover la clase de extensiones a nivel de espacio de nombres y declararla estática
        public static class ExtensionesValidacion
        {
            public static int ValidarEntero(this string texto)
            {
                return int.TryParse(texto, out int resultado) ? resultado : 0;
            }

            public static int AsegurarMinimo(this int valor, int minimo)
            {
                return Math.Max(valor, minimo);
            }
        }
    }
