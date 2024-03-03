package com.example.proyectojuego.objetos;

import android.content.Context;
import android.graphics.Canvas;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.BucleDeJuego;
import com.example.proyectojuego.grafico.Animator;
import com.example.proyectojuego.grafico.Sprite;
import com.example.proyectojuego.paneles.BarraDeVida;
import com.example.proyectojuego.paneles.Joystic;
import com.example.proyectojuego.MetodosUtiles;
import com.example.proyectojuego.R;


/*
    Nuestro Personaje, este lo podemos controlar con el joystic y
    extiende de circulo, que extiende del los objetosdelJuego
*/
public class Jugador extends Circulo {

    public static final double SPEED_PIXELS_PER_SECOND = 400.0;
    public static final int MAXIMOS_PUNTOS_DE_VIDA = 10;
    private static final double MAX_SPEED = SPEED_PIXELS_PER_SECOND/ BucleDeJuego.MAXIMOS_UPS;
    private final Joystic joystic;
    private BarraDeVida barraDeVida;
    private int puntosDeVida;
    //private Sprite sprite;
    private Animator animator;
    private EstadoJugador estadoJugador;


    public Jugador(Context context, Joystic joystic, double posicionX, double posicionY, double radio, Animator animator /*Sprite sprite*/){
        super(context,ContextCompat.getColor(context, R.color.jugador),posicionX,posicionY,radio);

        this.joystic = joystic;
        this.barraDeVida = new BarraDeVida(context,this);
        this.puntosDeVida = MAXIMOS_PUNTOS_DE_VIDA;
        //this.sprite = sprite;
        this.animator = animator;
        this.estadoJugador = new EstadoJugador(this);

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

        estadoJugador.actualizar();

    }

    public void CambiarPosicion(double posicionX, double posicionY) {

        this.posicionX = posicionX;
        this.posicionY = posicionY;

    }


    public void draw(Canvas canvas){
        //super.draw(canvas);

        animator.draw(canvas,this);



        barraDeVida.draw(canvas);

    }

    public int getPuntosDeVida() {
        return puntosDeVida;
    }

    public void setPuntosDeVida(int puntosDeVida) {
        //Solo podra perder vida si tiene vida es decir que no sea cero
        if(puntosDeVida >= 0 ){
        this.puntosDeVida = puntosDeVida;
        }

    }

    public EstadoJugador getEstadoJugador(){
        return estadoJugador;
    }

}
