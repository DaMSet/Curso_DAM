package com.example.proyectojuego;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

import java.util.zip.Adler32;

public class BucleDeJuego extends Thread {
    private static final double MAXIMOS_UPS = 60.0;
    private static final double UPS_PERIODO = 1E+3/MAXIMOS_UPS;
    private Juego juego;
    private SurfaceHolder surfaceHolder;
    private boolean estaFuncionando = false;
    private double mediaUPS;
    private double mediaFPS;



    public BucleDeJuego(Juego juego, SurfaceHolder surfaceHolder) {
        this.juego = juego;
        this.surfaceHolder = surfaceHolder;
    }

    public  double getMediaUPS() {

        return mediaUPS;
    }

    public  double getMediaFPS() {
        return mediaFPS;
    }

    public void inicioBucle() {
        estaFuncionando = true;
        start();
    }

    @Override
    public void run(){
        super.run();

        //Declaramos el tiempo y las variables de los ciclos
        int cuentaActualizacion = 0;
        int cuentaFrame  = 0;

        long tiempoInicio;
        long tiempoTranscurrido;
        long tiempoParado;


        //Bucle del juego

        Canvas canvas = null;
        tiempoInicio = System.currentTimeMillis();

        while (estaFuncionando){

            //Actualiza y renderiza el juego

            try{
                canvas = surfaceHolder.lockCanvas();

                synchronized (surfaceHolder){
                    juego.actualizar();
                    cuentaActualizacion++;
                    juego.draw(canvas);
                }

            }
            catch (IllegalArgumentException e)
            {
                e.printStackTrace();
            }finally {
                if(canvas != null)
                {
                    try {
                        surfaceHolder.unlockCanvasAndPost(canvas);
                        cuentaFrame++;
                    }catch (Exception e)
                    {
                        e.printStackTrace();
                    }
                }

            }




            //pausa el juego para que no se pase de FPS Y UPS
            tiempoTranscurrido = System.currentTimeMillis() - tiempoInicio;
            tiempoParado = (long)(cuentaActualizacion*UPS_PERIODO - tiempoTranscurrido);
            if(tiempoParado > 0){
                try {
                    sleep(tiempoParado);
                } catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }
            }

            //Salta los frames necesaios para que se mantengan en la cantidad elegida

            while(tiempoParado < 0 && cuentaActualizacion < MAXIMOS_UPS-1){
                juego.actualizar();
                cuentaActualizacion++;
                tiempoTranscurrido = System.currentTimeMillis() - tiempoInicio;
                tiempoParado = (long)(cuentaActualizacion*UPS_PERIODO - tiempoTranscurrido);

            }

            //calcula la media de UPS Y FPS

            tiempoTranscurrido = System.currentTimeMillis() -tiempoInicio;
            if(tiempoTranscurrido >= 1000){
                mediaUPS = cuentaActualizacion/(1E-3 * tiempoTranscurrido);
                mediaFPS = cuentaFrame/(1E-3 * tiempoTranscurrido);
                cuentaActualizacion = 0;
                cuentaFrame = 0 ;
                tiempoInicio = System.currentTimeMillis();

            }

        }
    }

}
