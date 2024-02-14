package com.example.proyectojuego;

import android.content.Context;

import android.graphics.Canvas;
import android.graphics.Paint;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;


/*
* Esta Clase maneja todos los objetos y es responsable de actualizar los objetos de la pantalla
* */
public class Juego extends SurfaceView implements SurfaceHolder.Callback {


    private BucleDeJuego bucleDeJuego;
    private Context context;

    public Juego(Context context) {
        super(context);

        //Obtenemos el surffaceHolder y el callback

        SurfaceHolder surfaceHolder = getHolder();
        surfaceHolder.addCallback(this);

        this.context = context;

        bucleDeJuego = new BucleDeJuego(this,surfaceHolder);

        setFocusable(true);

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

    }
    public void drawUPS(Canvas canvas){
        String mediaUPS = Double.toString(bucleDeJuego.getMediaUPS());

        Paint paint = new Paint();
        int color = ContextCompat.getColor(context,R.color.magenta);
        paint.setColor(color);
        paint.setTextSize(50);
        canvas.drawText("UPS:"+mediaUPS,100,100,paint);
     }

    public void drawFPS(Canvas canvas){
        String mediaFPS = Double.toString(bucleDeJuego.getMediaFPS());

        Paint paint = new Paint();
        int color = ContextCompat.getColor(context,R.color.magenta);
        paint.setColor(color);
        paint.setTextSize(50);
        canvas.drawText("FPS: "+mediaFPS,100,200,paint);
    }

    public void actualizar() {

    }
}
