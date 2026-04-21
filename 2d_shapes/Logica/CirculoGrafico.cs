using System;
using System.Drawing;

namespace _2d_shapes.logica
{
    public class CirculoGrafico : IFiguras
    {
        public int X { get; }
        public int Y { get; }
        public double Radio { get; set; }
        int IFiguras.X { get => X; set => throw new NotImplementedException(); }
        int IFiguras.Y { get => Y; set => throw new NotImplementedException(); }

        public CirculoGrafico(int x, int y) { X = x; Y = y; }

        public void Dibujar(Graphics g, Pen lapiz) => g.DrawEllipse(lapiz, X, Y, (float)(Radio * 2), (float)(Radio * 2));
        public double CalcularArea() => Math.PI * Math.Pow(Radio, 2);
        public double Calcularperimetro() => 2 * Math.PI * Radio;
    }
}