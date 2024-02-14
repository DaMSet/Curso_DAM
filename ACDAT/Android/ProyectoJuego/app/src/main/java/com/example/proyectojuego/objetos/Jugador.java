package com.example.proyectojuego.objetos;

import android.content.Context;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.BucleDeJuego;
import com.example.proyectojuego.Joystic;
import com.example.proyectojuego.R;
import com.example.proyectojuego.objetos.Circulo;


/*
    Nuestro Personaje, este lo podemos controlar con el joystic y
    extiende de circulo, que extiende del los objetosdelJuego
*/
public class Jugador extends Circulo {

    public static final double SPEED_PIXELS_PER_SECOND = 400.0;
    private static final double MAX_SPEDD = SPEED_PIXELS_PER_SECOND/ BucleDeJuego.MAXIMOS_UPS;
    private final Joystic joystic;




    public Jugador(Context context,Joystic joystic,double posicionX, double posicionY, double radio){
        super(context,ContextCompat.getColor(context, R.color.jugador),posicionX,posicionY,radio);

        this.joystic = joystic;


    }



    public void actualizar() {

        //Actualizamos la velocida en base a el actuator del joystic
        velocidadX = joystic.getActuatorX() * MAX_SPEDD;
        velocidadY = joystic.getActuatorY() * MAX_SPEDD;
        //Actualizamos la posicion
        posicionX += velocidadX;
        posicionY += velocidadY;

    }

    public void CambiarPosicion(double posicionX, double posicionY) {

        this.posicionX = posicionX;
        this.posicionY = posicionY;

    }
}
