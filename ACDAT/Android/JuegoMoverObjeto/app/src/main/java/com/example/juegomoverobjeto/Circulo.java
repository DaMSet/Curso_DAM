package com.example.juegomoverobjeto;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;

public class Circulo extends Figura {
    private float radio;
    private int color;
    public Circulo(float x, float y, float radio) {
        super(x, y);
        this.radio = radio;
        this.color = Color.BLUE;
    }

    public void setColor(int color) {
        this.color = color;
    }
    public float getRadio() {
        return radio;
    }

    public void setRadio(float radio) {
        this.radio = radio;
    }

    @Override
    public boolean isHovered(float x, float y) {
        double distanciaX = x - this.x;
        double distanciaY = y - this.y;
        return Math.pow(radio, 2) >  Math.pow(distanciaX, 2) + Math.pow(distanciaY, 2);
    }

    @Override
    public void onDraw(Canvas canvas, Paint paint) {
        paint.setColor(color);
        canvas.drawCircle(x, y, radio, paint);
    }


    public boolean isCenterInside(Circulo otroCirculo) {
        float centerX1 = x + radio;
        float centerY1 = y + radio;

        float centerX2 = otroCirculo.getX() + otroCirculo.getRadio();
        float centerY2 = otroCirculo.getY() + otroCirculo.getRadio();

        // Calcula la distancia entre los centros de los dos círculos
        double distanciaCentros = Math.sqrt(Math.pow(centerX1 - centerX2, 2) + Math.pow(centerY1 - centerY2, 2));

        // Comprueba si la distancia entre los centros es menor que el radio del círculo actual
        return distanciaCentros < radio;
    }

}
