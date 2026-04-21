using System;
using System.Drawing;

namespace _2d_shapes.logica
{
    public interface IFiguras
    {
        int X { get; set; }
        int Y { get; set; }
        void Dibujar(Graphics g, Pen lapiz);
        double CalcularArea();
        double Calcularperimetro();
    }
}