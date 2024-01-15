package com.example.a2trimestre_inicio;

public class Rectangulo extends Figura{

    double anchura,altura,x,y;

    public Rectangulo(double x, double y, double anchura, double altura) {
        super(x, y);
        this.anchura = anchura;
        this.altura = altura;
    }

    @Override
    public boolean IsHovered(double Posx, double PosY) {

        return (Posx > x && Posx < x+anchura) && (PosY > y && PosY <  y+altura) ;
    }
}
