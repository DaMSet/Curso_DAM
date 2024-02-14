package com.example.proyectojuego;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;

import androidx.core.content.ContextCompat;

public class Jugador {

    private double posicionX;
    private double posicionY;
    private double radio;
    private Paint paint;


    public Jugador(Context context,double posicionX, double posicionY, double radio){

        this.posicionX = posicionX;
        this.posicionY = posicionY;
        this.radio = radio;

        paint = new Paint();
        int color = ContextCompat.getColor(context,R.color.jugador);
        paint.setColor(color);

    }

    public void draw(Canvas canvas) {

         canvas.drawCircle((float)posicionX,(float) posicionY,(float)radio,paint);

    }

    public void actualizar() {


    }

    public void CambiarPosicion(double posicionX, double posicionY) {

        this.posicionX = posicionX;
        this.posicionY = posicionY;

    }
}
