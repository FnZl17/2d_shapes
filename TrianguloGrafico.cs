using System;
using System.Drawing;

namespace _2d_shapes.logica
{
    public class TrianguloGrafico : IFigura
    {
        public int X { get; }
        public int Y { get; }
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public TrianguloGrafico(int x, int y) { X = x; Y = y; }

        public double CalcularPerimetro() => LadoA + LadoB + LadoC;

        public double CalcularArea()
        {
            double s = CalcularPerimetro() / 2.0;
            double area = Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
            return double.IsNaN(area) ? 0 : area;
        }

        public void Dibujar(Graphics g, Pen lapiz)
        {
            if (LadoA + LadoB <= LadoC || LadoA + LadoC <= LadoB || LadoB + LadoC <= LadoA) return;
            //vertices - ley de cosenos
            double cosA = (Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2) - Math.Pow(LadoA, 2)) / (2 * LadoB * LadoC);
            double senA = Math.Sqrt(1 - Math.Pow(cosA, 2));

            Point[] puntos = {
                new Point(X, Y),
                new Point(X + (int)LadoC, Y),
                new Point(X + (int)(LadoB * cosA), Y - (int)(LadoB * senA))
            };

            g.DrawPolygon(lapiz, puntos);
        }
    }
}