package com.example.proyectojuego.objetos;

import android.graphics.Canvas;

/*
Es la clase abstracta principal de la que heredaran los objetos del juego
* */
public abstract class ObjetosDelJuego {
    protected double posicionX;
    protected double posicionY;
    protected double velocidadX = 0;
    protected double velocidadY = 0;
    protected double direccionX = 1;
    protected double direccionY = 0;

    public ObjetosDelJuego(double posicionX, double posicionY) {
        this.posicionX = posicionX;
        this.posicionY = posicionY;
    }



    public abstract void draw(Canvas canvas);

    public abstract void actualizar();

    public double getPosicionX() {
        return posicionX;
    }

    public double getPosicionY() {
        return posicionY;
    }

    protected static double getDistanciaEntreObjetos(ObjetosDelJuego obj1,ObjetosDelJuego obj2) {
        return  Math.sqrt(
                Math.pow(obj2.getPosicionX()- obj1.getPosicionX(),2)+
                        Math.pow(obj2.getPosicionY()- obj1.getPosicionY(),2)
        );
    }

    protected double getDireccionX() {
        return direccionX;
    }

    protected double getDireccionY() {
        return direccionY;
    }
}
