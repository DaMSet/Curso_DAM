package com.example.proyectojuego.objetos;

import android.content.Context;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.BucleDeJuego;
import com.example.proyectojuego.R;

public class Enemigo extends Circulo {

    private static final double SPEED_PIXELS_PER_SECOND = Jugador.SPEED_PIXELS_PER_SECOND*0.60;
    private static final double MAX_SPEED = SPEED_PIXELS_PER_SECOND/ BucleDeJuego.MAXIMOS_UPS;
    private final Jugador jugador;

    public Enemigo(Context context, Jugador jugador, double posicionX, double posicionY, double radio) {
        super(context, ContextCompat.getColor(context, R.color.enemigo),posicionX,posicionY,radio);
        this.jugador = jugador;
    }

    @Override
    public void actualizar() {
        //Actualizamos la velocidad del enemigo en la direccion de jugador

        //Calculamos el vector del enemigo a el jugador

        double distanciaAlJugadorX = jugador.getPosicionX()-posicionX;
        double distanciaAlJugadorY = jugador.getPosicionY()-posicionY;

        //Calculamos la distancia entre el enemigo , si mimo y el jugador

        double distanciaAlJugador = ObjetosDelJuego.getDistanciaEntreObjetos(this,jugador);

        //calculamos la direccion del enemigo al jugador
        double direccionX = distanciaAlJugadorX/distanciaAlJugador;
        double direccionY = distanciaAlJugadorY/distanciaAlJugador;

        //Ponemos la velocidad en la direccion a la que este el jugador

        if(distanciaAlJugador > 0){

            velocidadX = direccionX *MAX_SPEED;
            velocidadY = direccionY *MAX_SPEED;

        }else
            {
                velocidadX = 0;
                velocidadY = 0;
            }

        //Actualizamos la posicion del enemigo

            posicionX += velocidadX;
            posicionY += velocidadY;

    }
}
