package com.example.proyectojuego.objetos;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;

/*
Clase abstracta que utilizamos para guardar datos y metodos
que tendran los circulos en el juego
*/
public abstract class Circulo extends ObjetosDelJuego {
    protected double radio;
    protected Paint paint;

    public Circulo(Context context,int color,double posicionX, double posicionY,double radio) {
        super(posicionX, posicionY);

        this.radio = radio;
        paint = new Paint();

        paint.setColor(color);
    }

    //Este metodo mira si los dos objetos se estan tocando
    public static boolean estaChocando(Circulo obj1, Circulo obj2) {

        double distancia = getDistanciaEntreObjetos(obj1,obj2);
        double distanciaParaChocar =  obj1.getRadio() +obj2.getRadio();

        if(distancia < distanciaParaChocar){return true;}
        else {
            return false;
        }

    }

    protected double getRadio(){
        return radio;
    };

    public void draw(Canvas canvas) {

        canvas.drawCircle((float)posicionX,(float) posicionY,(float)radio,paint);

    }


}
