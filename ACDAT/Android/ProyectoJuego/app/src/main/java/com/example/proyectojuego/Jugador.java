package com.example.proyectojuego;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;

import androidx.core.content.ContextCompat;

public class Jugador {

    private static final double SPEED_PIXELS_PER_SECOND = 400.0;
    private static final double MAX_SPEDD = SPEED_PIXELS_PER_SECOND/BucleDeJuego.MAXIMOS_UPS;
    private double posicionX;
    private double posicionY;
    private double radio;
    private Paint paint;
    private double velocidadX;
    private double velocidadY;

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

    public void actualizar(Joystic joystic) {

        velocidadX = joystic.getActuatorX() * MAX_SPEDD;
        velocidadY = joystic.getActuatorY() * MAX_SPEDD;

        posicionX += velocidadX;
        posicionY += velocidadY;

    }

    public void CambiarPosicion(double posicionX, double posicionY) {

        this.posicionX = posicionX;
        this.posicionY = posicionY;

    }
}
