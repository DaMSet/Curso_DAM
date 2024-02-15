package com.example.proyectojuego;

import kotlin.contracts.Returns;

public class MetodosUtiles {

    //OBTENEMOS LA DISTANCIA ENTRE DOS PUNTOS
    public static double getDistanciaEntrePuntos(double punto1X, double punto1Y, double punto2X, double punto2Y) {

        return Math.sqrt(
                Math.pow(punto1X - punto2X,2)+
                Math.pow(punto1Y - punto2Y,2)
        );

    }
}
