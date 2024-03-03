package com.example.proyectojuego;


import android.content.Context;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.media.MediaPlayer;
import android.provider.MediaStore;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;

import com.example.proyectojuego.grafico.Animator;
import com.example.proyectojuego.grafico.SpriteSheet;
import com.example.proyectojuego.objetos.Circulo;
import com.example.proyectojuego.objetos.Bala;
import com.example.proyectojuego.objetos.Enemigo;
import com.example.proyectojuego.objetos.Jugador;
import com.example.proyectojuego.paneles.Joystic;
import com.example.proyectojuego.paneles.JuegoTerminado;
import com.example.proyectojuego.paneles.Puntos;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;


/*
* Esta Clase maneja todos los objetos y es responsable de actualizar los objetos de la pantalla
* */
public class Juego extends SurfaceView implements SurfaceHolder.Callback {


    private final Jugador jugador;
    private final Joystic joystic;
    //private final Enemigo enemigo;
    private BucleDeJuego bucleDeJuego;

    private List<Enemigo> ListaDeEnemigos = new ArrayList<Enemigo>();
    private List<Bala> listaDeBalas = new ArrayList<Bala>();
    private int joysticPointerID = 0;
    private int NumeroDeBalasEnElCargador = 0;
    private JuegoTerminado gameOver;
    private Puntos puntosDelJuego;
    private Bitmap fondo1;

    private MediaPlayer mediaPlayer;
    private MediaPlayer sonidoDisparo;


    public Juego(Context context) {
        super(context);



        //Obtenemos el surffaceHolder y el callback

        SurfaceHolder surfaceHolder = getHolder();
        surfaceHolder.addCallback(this);


        bucleDeJuego = new BucleDeJuego(this,surfaceHolder);

        //Iniciamos los paneles del juego

        gameOver = new JuegoTerminado(getContext());
        puntosDelJuego = new Puntos(getContext());

        joystic = new Joystic(275,700,70,40);

        //Iniciamos los objetos del juego


        SpriteSheet spriteSheet = new SpriteSheet(context);

        Animator animator = new Animator(spriteSheet.getArrayJugadorSprite());

        jugador = new Jugador(getContext(),joystic,2*500,500,30,animator/*spriteSheet.getJugadorSprite()*/);
        //enemigo = new Enemigo(getContext(),jugador,500,200,30);


        mediaPlayer = MediaPlayer.create(context,R.raw.musica_fondo);
        mediaPlayer.setLooping(true);

        sonidoDisparo = MediaPlayer.create(context,R.raw.pium);


        setFocusable(true);

    }


    @Override
    public boolean onTouchEvent(MotionEvent event){

        //Manejamos los eventos al tocar la pantalla

        switch (event.getActionMasked())
        {
            case MotionEvent.ACTION_DOWN:
            case MotionEvent.ACTION_POINTER_DOWN:
                if(joystic.getEstaPresionado()){
                    //SI EL JOYSTIC ESTA PRESIONADO ANTES DE ESTE EVENTO ENTONCES PREPARAMOS EL DIPARO

                    NumeroDeBalasEnElCargador++;

                }
                else if(joystic.estaPresionado((double)event.getX(),(double)event.getY()))
                {
                    //Si el joystic esta presionado guardamos su id para poder comprovar que sea el joystic el que es utilizado
                    joysticPointerID = event.getPointerId(event.getActionIndex());
                    joystic.setEstaPresionado(true);
                }
                else{
                    //SI EL JOYSTIC NO ESTA PRESIONADO TAMBIEN PREPARAMOS EL DIPARO
                    NumeroDeBalasEnElCargador++;
                }

            case MotionEvent.ACTION_MOVE:

                if(joystic.getEstaPresionado())
                {
                    joystic.setActuator((double)event.getX(),(double)event.getY());
                }

                return true;

            case MotionEvent.ACTION_UP:
            case MotionEvent.ACTION_POINTER_UP:

                if(joysticPointerID == event.getPointerId(event.getActionIndex())){

                    joystic.setEstaPresionado(false);
                    joystic.resetearActuator();

                }


                return true;
        }

        return super.onTouchEvent(event);
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder holder) {

        bucleDeJuego.inicioBucle();

        // Cargamos la imagen de fondo
        fondo1 = BitmapFactory.decodeResource(getResources(), R.drawable.fondo);

        //pònemos la musica

        mediaPlayer.start();

    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder holder, int format, int width, int height) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder holder) {

        mediaPlayer.stop();
        mediaPlayer.release();

    }

    @Override
    public void draw(Canvas canvas){
        super.draw(canvas);

        // Dibujamos la imagen de fondo
        canvas.drawBitmap(fondo1, 0, 0, null);

        drawUPS(canvas);
        drawFPS(canvas);



        //Aqui dibujaremos los objetos del juego

        jugador.draw(canvas);
        //enemigo.draw(canvas);

        //Mostramos a los enemigos
        for (Enemigo enemigo: ListaDeEnemigos)
        {
            enemigo.draw(canvas);
        }

        //Mostramos las balas
        for (Bala bala: listaDeBalas)
        {
            bala.draw(canvas);
        }

        //Aqui estan los paneles del juego
        joystic.draw(canvas);

        //Mostramos los puntos
        puntosDelJuego.draw(canvas);

        //Sera el fin del juego si el jugador pierde toda la vida
        if(jugador.getPuntosDeVida() <= 0){
            gameOver.draw(canvas);
        }


    }
    public void drawUPS(Canvas canvas){
        String mediaUPS = Double.toString(bucleDeJuego.getMediaUPS());

        Paint paint = new Paint();
        int color = ContextCompat.getColor(getContext(),R.color.magenta);
        paint.setColor(color);
        paint.setTextSize(50);
        canvas.drawText("UPS:"+mediaUPS,100,100,paint);


     }

    public void drawFPS(Canvas canvas){
        String mediaFPS = Double.toString(bucleDeJuego.getMediaFPS());

        Paint paint = new Paint();
        int color = ContextCompat.getColor(getContext(),R.color.magenta);
        paint.setColor(color);
        paint.setTextSize(50);
        canvas.drawText("FPS: "+mediaFPS,100,200,paint);
    }

    public void actualizar() {



        //Si el jugador esta muerto, dejaremos de actualizar el juego

        if(jugador.getPuntosDeVida() <= 0){
            return;
        }

        //Actualizamos el estado del juego
        joystic.actualizar();
        jugador.actualizar();

        //enemigo.actualizar();


        //Spawnea enemigos si es momento para que salgan
        if(Enemigo.ListoParaSpawnear()){
            ListaDeEnemigos.add(new Enemigo(getContext(),jugador));
        }

        //Actualizar el estado de cada enemigo

        for (Enemigo enemigo : ListaDeEnemigos){
            enemigo.actualizar();
        }

        //

        while(NumeroDeBalasEnElCargador > 0){
            listaDeBalas.add(new Bala(getContext(),jugador));
            NumeroDeBalasEnElCargador--;

            sonidoDisparo.start();
        }

        //Actualizar el estado de cada bala

        for (Bala bala : listaDeBalas){
            bala.actualizar();
        }





        //chequeamos atraves de la lista de enemigos para comprobar las colisiones entre cada enemigo con el jugador y las balas tambien

        Iterator<Enemigo> iteradorListaEnemigos = ListaDeEnemigos.iterator();

        while (iteradorListaEnemigos.hasNext())
        {
            Circulo enemigo = iteradorListaEnemigos.next();

            if(Circulo.estaChocando(enemigo,jugador))
            {
                //Si choca con el jugador lo borramos

                iteradorListaEnemigos.remove();

                //Y quitamos vida a el jugador

                jugador.setPuntosDeVida(jugador.getPuntosDeVida() - 1);

                continue;

            }

            Iterator<Bala> iteradorListaDeBalas = listaDeBalas.iterator();

            while(iteradorListaDeBalas.hasNext()){

                Circulo bala = iteradorListaDeBalas.next();
                //Con esto queremos borrar tanto la bala como el enemigo

                if(Circulo.estaChocando(bala,enemigo)){
                    iteradorListaDeBalas.remove();
                    iteradorListaEnemigos.remove();

                    //Si un enemigo es eliminado por una bala sumaremos puntos a un proximo contador

                    puntosDelJuego.sumarpunto();

                    break;


                }

            }

        }


    }
}
