package com.example.proyectojuego.objetos;

import android.content.Context;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.BucleDeJuego;
import com.example.proyectojuego.Joystic;
import com.example.proyectojuego.MetodosUtiles;
import com.example.proyectojuego.R;


/*
    Nuestro Personaje, este lo podemos controlar con el joystic y
    extiende de circulo, que extiende del los objetosdelJuego
*/
public class Jugador extends Circulo {

    public static final double SPEED_PIXELS_PER_SECOND = 400.0;
    private static final double MAX_SPEED = SPEED_PIXELS_PER_SECOND/ BucleDeJuego.MAXIMOS_UPS;
    private final Joystic joystic;




    public Jugador(Context context,Joystic joystic,double posicionX, double posicionY, double radio){
        super(context,ContextCompat.getColor(context, R.color.jugador),posicionX,posicionY,radio);

        this.joystic = joystic;


    }



    public void actualizar() {

        //Actualizamos la velocida en base a el actuator del joystic
        velocidadX = joystic.getActuatorX() * MAX_SPEED;
        velocidadY = joystic.getActuatorY() * MAX_SPEED;

        //Actualizamos la posicion
        posicionX += velocidadX;
        posicionY += velocidadY;

        //actualizamos la direccion a la que mira
        if(velocidadX != 0 || velocidadY != 0){
            double distancia = MetodosUtiles.getDistanciaEntrePuntos(0,0,velocidadX,velocidadY);
            direccionX = velocidadX/distancia;
            direccionY = velocidadY/distancia;

        }

    }

    public void CambiarPosicion(double posicionX, double posicionY) {

        this.posicionX = posicionX;
        this.posicionY = posicionY;

    }
}
