package com.example.proyectojuego.objetos;

import java.security.PublicKey;

public class EstadoJugador {


    public enum Estado{
        PARADO,
        ABAJO,
        ABAJO_MOVERSE,
        DERECHA,
        DERECHA_MOVERSE,
        IZQUIERDA,
        IZQUIERDA_MOVERSE,
        ARRIBA,
        ARRIBA_MOVERSE

    }

    private final Jugador jugador;
    private Estado estado;


    public EstadoJugador(Jugador jugador){
        this.jugador = jugador;
        this.estado = Estado.PARADO;
    }

    public Estado getEstado(){
        return estado;
    }

    public void actualizar(){

        switch (estado){
            case PARADO:
                if(jugador.velocidadX !=0 || jugador.velocidadY !=0 )
                    estado = Estado.ABAJO;
                break;

            case ABAJO:

                if(jugador.velocidadX !=0 || jugador.velocidadY !=0 )
                    estado = Estado.ABAJO_MOVERSE;


                break;

            case ABAJO_MOVERSE:

                if(jugador.velocidadX ==0 || jugador.velocidadY ==0 )
                    estado = Estado.PARADO;

                break;
            case DERECHA:
                if (jugador.velocidadX == 0 && jugador.velocidadY == 0) {
                    estado = Estado.PARADO;
                } else if (jugador.velocidadY != 0) {
                    estado = Estado.ABAJO_MOVERSE;
                } else {
                    estado = Estado.DERECHA_MOVERSE;
                }
                break;

            case DERECHA_MOVERSE:
                if (jugador.velocidadX == 0 && jugador.velocidadY == 0) {
                    estado = Estado.PARADO;
                }
                break;

            case IZQUIERDA:
                if (jugador.velocidadX == 0 && jugador.velocidadY == 0) {
                    estado = Estado.PARADO;
                } else if (jugador.velocidadY != 0) {
                    estado = Estado.ABAJO_MOVERSE;
                } else {
                    estado = Estado.IZQUIERDA_MOVERSE;
                }
                break;

            case IZQUIERDA_MOVERSE:
                if (jugador.velocidadX == 0 && jugador.velocidadY == 0) {
                    estado = Estado.PARADO;
                }
                break;

            case ARRIBA:
                if (jugador.velocidadY == 0) {
                    estado = Estado.PARADO;
                } else if (jugador.velocidadX != 0) {
                    estado = Estado.ABAJO_MOVERSE;
                } else {
                    estado = Estado.ARRIBA_MOVERSE;
                }
                break;

            case ARRIBA_MOVERSE:
                if (jugador.velocidadY == 0) {
                    estado = Estado.PARADO;
                }
                break;
        }

    }

}
