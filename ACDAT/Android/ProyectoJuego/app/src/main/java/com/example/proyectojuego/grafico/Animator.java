package com.example.proyectojuego.grafico;

import android.graphics.Canvas;

import com.example.proyectojuego.objetos.EstadoJugador;
import com.example.proyectojuego.objetos.Jugador;

public class Animator {

    private Sprite[] arrayJugadorSprite;
    public Animator(Sprite[] arrayJugadorSprite) {

        this.arrayJugadorSprite = arrayJugadorSprite;

    }


    public void draw(Canvas canvas, Jugador jugador) {

        switch (jugador.getEstadoJugador().getEstado()){
            case PARADO:
                drawFrame(canvas,jugador,arrayJugadorSprite[0]);
                break;

            case ABAJO:

                drawFrame(canvas,jugador,arrayJugadorSprite[1]);

                break;

            case ABAJO_MOVERSE:

                drawFrame(canvas,jugador,arrayJugadorSprite[2]);

                break;
            case DERECHA:

                drawFrame(canvas,jugador,arrayJugadorSprite[3]);

                break;

            case DERECHA_MOVERSE:

                drawFrame(canvas,jugador,arrayJugadorSprite[4]);

                break;

            case IZQUIERDA:

                drawFrame(canvas,jugador,arrayJugadorSprite[5]);

                break;

            case IZQUIERDA_MOVERSE:

                drawFrame(canvas,jugador,arrayJugadorSprite[6]);

                break;

            case ARRIBA:

                drawFrame(canvas,jugador,arrayJugadorSprite[7]);

                break;

            case ARRIBA_MOVERSE:

                drawFrame(canvas,jugador,arrayJugadorSprite[8]);

                break;
        }

    }

    public void drawFrame(Canvas canvas, Jugador jugador,Sprite sprite){

        sprite.draw(canvas,
                (int)jugador.getPosicionX() - 30,
                (int)jugador.getPosicionY()) ;

    }


}
