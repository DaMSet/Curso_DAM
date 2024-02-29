package com.example.proyectojuego.paneles;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;

import com.example.proyectojuego.MetodosUtiles;

public class Joystic {


    private int radioCirculoInterno;
    private int radioCirculoExterno;
    private int circuloInternoX;
    private int circuloInternoY;
    private int circuloExternoX;
    private int circuloExternoY;

    private Paint circuloInternoPaint;
    private Paint circuloExternoPaint;
    private double joystickCenterToTouchDistance;
    private boolean estaPresionado;
    private double actuatorX;
    private double actuatorY;
    public Joystic(int  centroX, int centroY,int radioCirculoExterno,int radioCirculoInterno){

        //Necesitamos dos circulos uno interno y otro externo para crear el joystic
        circuloExternoX = centroX;
        circuloExternoY = centroY;
        circuloInternoX = centroX;
        circuloInternoY = centroY;


        this.radioCirculoExterno = radioCirculoExterno;
        this.radioCirculoInterno = radioCirculoInterno;


        //Pintamos los circulos

        circuloExternoPaint = new Paint();
        circuloExternoPaint.setColor(Color.GRAY);
        circuloExternoPaint.setStyle(Paint.Style.FILL_AND_STROKE);

        circuloInternoPaint = new Paint();
        circuloInternoPaint.setColor(Color.BLUE);
        circuloInternoPaint.setStyle(Paint.Style.FILL_AND_STROKE);

    }
    public void draw(Canvas canvas) {

        //Dibujamos el circulo exterior


        //Circulo externo
        canvas.drawCircle(
                circuloExternoX,
                circuloExternoY,
                radioCirculoExterno,
                circuloExternoPaint
        );

        //Circulo interno
        canvas.drawCircle(
                circuloInternoX,
                circuloInternoY,
                radioCirculoInterno,
                circuloInternoPaint
        );


    }

    public void actualizar() {

        actualizarPosicionCirculoInterno();
        
    }

    private void actualizarPosicionCirculoInterno() {

        circuloInternoX = (int) (circuloExternoX + actuatorX * radioCirculoExterno);
        circuloInternoY = (int) (circuloExternoY + actuatorY * radioCirculoExterno);
    }

    public boolean estaPresionado(double posicionTocadaX, double posicionTocadaY) {
        joystickCenterToTouchDistance = MetodosUtiles.getDistanciaEntrePuntos(
                circuloExternoX,
                circuloExternoY,
                posicionTocadaX,
                posicionTocadaY
        );




        return joystickCenterToTouchDistance < radioCirculoExterno;
    }

    public void setEstaPresionado(boolean estaPresionado) {
        this.estaPresionado = estaPresionado;
    }
    public boolean getEstaPresionado() {
        return this.estaPresionado;
    }

    public void setActuator(double posicionTocadaX, double posicionTocadaY) {

        double deltaX =  posicionTocadaX - circuloExternoX;
        double deltaY =  posicionTocadaY - circuloExternoY;
        Double deltaDistance = MetodosUtiles.getDistanciaEntrePuntos(0,0,deltaX,deltaY);


        if(deltaDistance < radioCirculoExterno)
        {
            actuatorX = deltaX/radioCirculoExterno;
            actuatorY = deltaY/radioCirculoExterno;
        }else
        {
            actuatorX = deltaX/deltaDistance;
            actuatorY = deltaY/deltaDistance;
        }

    }

    public void resetearActuator() {
        actuatorX = 0.0;
        actuatorY = 0.0;

    }

    public double getActuatorX() {
        return actuatorX;
    }

    public double getActuatorY() {
        return actuatorY;
    }
}
