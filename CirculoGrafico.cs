using System;
using System.Drawing;

namespace _2d_shapes.logica
{
    public class CirculoGrafico : IFiguras
    {
        public int X { get; }
        public int Y { get; }
        public int Radio { get; set; }

        public CirculoGrafico(int x, int y) { X = x; Y = y; }

        public void Dibujar(Graphics g, Pen lapiz) => g.DrawEllipse(lapiz, X, Y, Radio * 2, Radio * 2);
        public double CalcularArea() => Math.PI * Math.Pow(Radio, 2);
        public double CalcularPerimetro() => 2 * Math.PI * Radio;
    }
}