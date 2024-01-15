package com.example.a2trimestre_inicio;

public abstract class Figura {

    private double x,y;
    public Figura() {

    }

    public Figura(double x, double y) {
        this.x = x;
        this.y = y;

    }

    public abstract boolean IsHovered(double Posx, double PosY);



}
