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

    public double getAnchura() {
        return anchura;
    }

    public void setAnchura(double anchura) {
        this.anchura = anchura;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }
}
