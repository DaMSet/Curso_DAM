package com.example.proyectojuego.objetos;

import android.content.Context;
import android.health.connect.datatypes.units.Velocity;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.BucleDeJuego;
import com.example.proyectojuego.R;

public class Bala extends Circulo{

    public static final double SPEED_PIXELS_PER_SECOND = 800.0;
    private static final double MAX_SPEED = SPEED_PIXELS_PER_SECOND/ BucleDeJuego.MAXIMOS_UPS;

    private Jugador disparador;

    public Bala(Context context, Jugador disparador) {
        super(
                context,
                ContextCompat.getColor(context, R.color.bala),
                disparador.getPosicionX(),
                disparador.getPosicionY(),
                25
        );

        velocidadX = disparador.getDireccionX()*MAX_SPEED;
        velocidadY = disparador.getDireccionY()*MAX_SPEED;

    }



    @Override
    public void actualizar() {
        posicionX += velocidadX;
        posicionY += velocidadY;


    }



}
