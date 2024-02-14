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

    public void draw(Canvas canvas) {

        canvas.drawCircle((float)posicionX,(float) posicionY,(float)radio,paint);

    }


}
