package com.example.proyectojuego.objetos;

import android.content.Context;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.BucleDeJuego;
import com.example.proyectojuego.R;

public class Enemigo extends Circulo {

    private static final double SPEED_PIXELS_PER_SECOND = Jugador.SPEED_PIXELS_PER_SECOND*0.60;
    private static final double MAX_SPEED = SPEED_PIXELS_PER_SECOND/ BucleDeJuego.MAXIMOS_UPS;
    private static final double SPAWNS_POR_MINUTO = 20;
    private static final double SPAWNS_POR_SEGUNDO = SPAWNS_POR_MINUTO/60.0;
    private static final double ACTUALIZACIONES_POR_SPAWN = BucleDeJuego.MAXIMOS_UPS/SPAWNS_POR_SEGUNDO;
    private static double actualizacionHastaElSiguienteSpawn = ACTUALIZACIONES_POR_SPAWN;
    private final Jugador jugador;

    public Enemigo(Context context, Jugador jugador, double posicionX, double posicionY, double radio) {
        super(context, ContextCompat.getColor(context, R.color.enemigo),posicionX,posicionY,radio);
        this.jugador = jugador;
    }

    public Enemigo(Context context, Jugador jugador) {
        super(
                context,
                ContextCompat.getColor(context, R.color.enemigo),
                Math.random()*1000,
                Math.random()*1000,
                30
        );
        this.jugador = jugador;



    }

    /*
        Este metodo mira si un enemigo debe spawnear de acuerdo a un numero por minuto
    */
    public static boolean ListoParaSpawnear() {

        if(actualizacionHastaElSiguienteSpawn <= 0)
        {
            actualizacionHastaElSiguienteSpawn += ACTUALIZACIONES_POR_SPAWN;
            return true;
        }else
            {
                actualizacionHastaElSiguienteSpawn--;
                return false;
            }

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
