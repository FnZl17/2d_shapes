using System;
using System.Drawing;

namespace _2d_shapes.logica
{
    public class RectanguloGrafico : IFiguras
    {
        public int X { get; }
        public int Y { get; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        int IFiguras.X { get => X; set => throw new NotImplementedException(); }
        int IFiguras.Y { get => Y; set => throw new NotImplementedException(); }

        public RectanguloGrafico(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double CalcularArea() => Ancho * Largo;
        public double CalcularPerimetro() => 2 * (Ancho + Largo);

        public void Dibujar(Graphics g, Pen lapiz)
        {
            if (Ancho > 0 && Largo > 0)
            {
                g.DrawRectangle(lapiz, X, Y, (float)Ancho, (float)Largo);
            }
        }

        public double Calcularperimetro()
        {
            throw new NotImplementedException();
        }
    }
}