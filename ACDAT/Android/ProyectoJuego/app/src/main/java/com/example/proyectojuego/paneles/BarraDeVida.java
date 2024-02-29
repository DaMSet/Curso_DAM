package com.example.proyectojuego.paneles;


import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.R;
import com.example.proyectojuego.objetos.Jugador;

/*
* la barra de vida se mostrara encima del personaje mostrando la vida del mismo
* */
public class BarraDeVida {

    private Jugador jugador;
    private int anchura,altura,margen;
    private Paint bordePaint,vidaPaint;
    public BarraDeVida(Context context, Jugador jugador){

    this.jugador = jugador;
    this.anchura = 100;
    this.altura = 20;
    this.margen = 2;


    this.bordePaint = new Paint();
    int colorBorde = ContextCompat.getColor(context, R.color.bordebarraDeVida);
    bordePaint.setColor(colorBorde);

    this.vidaPaint = new Paint();
    int colorVida = ContextCompat.getColor(context, R.color.barraDeVida);
    vidaPaint.setColor(colorVida);
    }


    public void draw(Canvas canvas){

        float x = (float) jugador.getPosicionX();
        float y = (float) jugador.getPosicionY();
        float distanciaAlJugador = 30;
        float porcentajeDeVida = (float) jugador.getPuntosDeVida()/jugador.MAXIMOS_PUNTOS_DE_VIDA;

        //Primero dibujamos el borde del rectangulo

        float bordeIzquierda,bordeArriba,bordeDerecha,bordeAbajo;
        bordeIzquierda = x - anchura/2;
        bordeDerecha = x + anchura/2;
        bordeAbajo = y - distanciaAlJugador;
        bordeArriba = bordeAbajo - altura;

        canvas.drawRect(bordeIzquierda,bordeArriba,bordeDerecha,bordeAbajo,bordePaint);


        //despues dibujamos la vida en si dentro de este
        float vidaIzquierda,vidaArriba,vidaDerecha,vidaAbajo,vidaAncho,vidaAlto;

        // Calcula el ancho del borde
        float bordeAncho = bordeDerecha - bordeIzquierda;

        vidaAncho = anchura - 2*margen;
        vidaAlto = altura - 2*margen;
        vidaIzquierda =  bordeIzquierda + margen ;
        vidaDerecha = vidaIzquierda + vidaAncho * porcentajeDeVida;
        vidaAbajo = bordeAbajo - margen;
        vidaArriba = vidaAbajo - vidaAlto;

        canvas.drawRect(vidaIzquierda,vidaArriba,vidaDerecha,vidaAbajo,vidaPaint);

    }

}
