package com.example.juegomoverobjeto;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback{


    private GameThread gameThread;
    private Rectangulo rectangulo, rectangulo2;
    private Paint paint;
    private Paint linePaint;


    public MoverFiguras(Context context) {
        super(context);
        //Uno esta relleno por defecto y el otro lo editamos
        rectangulo = new Rectangulo(200, 200, 300, 200);

        rectangulo2 = new Rectangulo(700, 300, 300, 200);

        paint = new Paint();
        linePaint = new Paint();
        //setBackgroundColor(Color.BLACK);
        setBackgroundColor(Color.WHITE);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawColor(Color.BLACK);
        rectangulo.onDraw(canvas, paint);

        paint.setStyle(Paint.Style.STROKE);
        paint.setStrokeWidth(5);

        rectangulo2.onDraw(canvas, paint);

        paint.setStyle(Paint.Style.FILL);

        invalidate();
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        //return super.onTouchEvent(event);
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                if (rectangulo.isHovered(event.getX(), event.getY())) {
                    rectangulo.setxInicial(event.getX());
                    rectangulo.setyInicial(event.getY());
                }

                /*
                if (rectangulo2.isHovered(event.getX(), event.getY())) {
                    rectangulo2.setxInicial(event.getX());
                    rectangulo2.setyInicial(event.getY());
                }*/

                break;
            case MotionEvent.ACTION_MOVE:
                rectangulo.mover(event.getX(), event.getY());
                //rectangulo2.mover(event.getX(), event.getY());

                // Verifica si rectangulo1 está en el centro de rectangulo2
                if (rectangulo.isCenterInside(rectangulo2)) {
                    rectangulo.setColor(Color.GREEN);  // Cambia el color a verde

                    rectangulo.setX(rectangulo2.getX());
                    rectangulo.setY(rectangulo2.getY());

                } else {
                    rectangulo.setColor(Color.RED);  // Restaura el color original
                }



                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
                rectangulo.setxInicial(null);
                rectangulo.setyInicial(null);

               // rectangulo2.setxInicial(null);
               // rectangulo2.setyInicial(null);

                break;
        }

        return true;
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder surfaceHolder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder surfaceHolder, int i, int i1, int i2) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder surfaceHolder) {
        boolean retry = true;
        gameThread.setRunning(false);

        while(retry) {
            try {
                gameThread.join();
                retry = false;
            } catch (InterruptedException e) {

            }
        }
    }

}
