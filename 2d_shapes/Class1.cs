using System;

public interface iDibujable
{
    void Dibujar(Graphics g, Pen lapiz);
}   

public class Rectangulo : iDibujable
{
    public int x { get; set; }
    public int y { get; set; }
    public int Ancho { get; set; }
    public int Largo { get; set; }

    public Rectangulo (int x, int y)
    {
        x= x;
        y= y;
    }
    
    public void Dibujar(Graphics g, Pen lapiz)
    {
        if(Ancho>0 && Largo>0)
        g.DrawRectangle(lapiz, 0, 0, Ancho, Largo);
    }
}