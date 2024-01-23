package com.example.juegomoverobjeto;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;

public class Rectangulo extends Figura {
    private double width;
    private double height;

    private int color;

    public Rectangulo(float x, float y, double width, double height) {
        super(x, y);
        this.width = width;
        this.height = height;
        this.color = Color.RED;
    }

    public void setColor(int color) {
        this.color = color;
    }
    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public boolean isHovered(float x, float y) {
        return x >= this.x && x <= this.x + width && y >= this.y && y <= this.y + height;
    }

    @Override
    public void onDraw(Canvas canvas, Paint paint) {
        paint.setColor(color);
        canvas.drawRect(getX(), getY(), getX()+(float)getWidth(), getY()+(float)getHeight(), paint);
    }

    public boolean isCenterInside(Rectangulo otroRectangulo) {
        float centerX1 = (getX() + getX()+(float)getWidth()) / 2;
        float centerY1 = (getY() + getY()+(float)getHeight()) / 2;

        float centerX2 = (otroRectangulo.getX() + otroRectangulo.getX()+(float)getWidth()) / 2;
        float centerY2 = (otroRectangulo.getY() + otroRectangulo.getY()+(float)getHeight()) / 2;

        // Define una distancia de proximidad para considerar "cerca del centro"
        float distanciaProximidad = 50;

        // Comprueba si el centro de rectangulo1 está cerca del centro de rectangulo2
        return Math.abs(centerX1 - centerX2) < distanciaProximidad &&
                Math.abs(centerY1 - centerY2) < distanciaProximidad;
    }
}
