package com.example.proyectojuego;

import android.content.Context;

import android.graphics.Canvas;
import android.graphics.Paint;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;

import com.example.proyectojuego.objetos.Enemigo;
import com.example.proyectojuego.objetos.Jugador;


/*
* Esta Clase maneja todos los objetos y es responsable de actualizar los objetos de la pantalla
* */
public class Juego extends SurfaceView implements SurfaceHolder.Callback {


    private final Jugador jugador;
    private final Joystic joystic;
    private final Enemigo enemigo;
    private BucleDeJuego bucleDeJuego;


    public Juego(Context context) {
        super(context);


        //Obtenemos el surffaceHolder y el callback

        SurfaceHolder surfaceHolder = getHolder();
        surfaceHolder.addCallback(this);


        bucleDeJuego = new BucleDeJuego(this,surfaceHolder);

        //Iniciamos los objetos del juego

        joystic = new Joystic(275,700,70,40);
        jugador = new Jugador(getContext(),joystic,2*500,500,30);
        enemigo = new Enemigo(getContext(),jugador,500,200,30);

        setFocusable(true);

    }


    @Override
    public boolean onTouchEvent(MotionEvent event){

        //Manejamos los eventos al tocar la pantalla

        switch (event.getAction())
        {
            case MotionEvent.ACTION_DOWN:
                if(joystic.estaPresionado((double)event.getX(),(double)event.getY()))
                {
                    joystic.setEstaPresionado(true);
                }

            case MotionEvent.ACTION_MOVE:

                if(joystic.getEstaPresionado())
                {
                    joystic.setActuator((double)event.getX(),(double)event.getY());
                }

                return true;

            case MotionEvent.ACTION_UP:

                joystic.setEstaPresionado(false);
                joystic.resetearActuator();
                return true;
        }

        return super.onTouchEvent(event);
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder holder) {
        bucleDeJuego.inicioBucle();
    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder holder, int format, int width, int height) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder holder) {

    }

    @Override
    public void draw(Canvas canvas){
        super.draw(canvas);
        drawUPS(canvas);
        drawFPS(canvas);

        joystic.draw(canvas);
        jugador.draw(canvas);
        enemigo.draw(canvas);

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
        //Actualizamos el estado del juego
        joystic.actualizar();
        jugador.actualizar();
        enemigo.actualizar();

    }
}
