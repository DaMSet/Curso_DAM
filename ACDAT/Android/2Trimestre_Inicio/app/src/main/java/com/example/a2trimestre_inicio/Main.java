package com.example.a2trimestre_inicio;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Context;
import android.content.pm.ActivityInfo;
import android.graphics.Canvas;
import android.graphics.Color;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.Window;
import android.view.WindowManager;

public class Main extends SurfaceView implements SurfaceHolder.Callback {

    private HiloPintar hiloPintar;

    public Main(Context context) {
        super(context);
        getHolder().addCallback(this);
        setBackgroundColor(Color.BLACK);
    }

    protected void onDraw(Canvas canvas)
    {
        super.onDraw(canvas);
        //setBackgroundColor(Color.BLACK);
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder holder) {

        hiloPintar = new HiloPintar(getHolder(),this);
        hiloPintar.setRunning(true);
        hiloPintar.run();

    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder holder, int format, int width, int height) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder holder) {

        boolean retry = true;
        hiloPintar.setRunning(false);

            while(retry){

                try {
                    hiloPintar.join();
                    retry = false;

                }catch (InterruptedException e){}

            }


    }
    @Override
    public boolean onTouchEvent(MotionEvent motionEvent)
    {
        return true;
    }

}




