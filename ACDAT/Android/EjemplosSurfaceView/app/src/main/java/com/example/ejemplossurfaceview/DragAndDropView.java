package com.example.ejemplossurfaceview;

import android.content.Context;
import android.graphics.Canvas;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

public class DragAndDropView extends SurfaceView implements SurfaceHolder.Callback{

    public DragAndDropView(Context context)
    {
        super(context);
        getHolder().addCallback(this);

    }
        @Override
        public void surfaceCreated(@NonNull SurfaceHolder holder) {

        }

        @Override
        public void surfaceChanged(@NonNull SurfaceHolder holder, int format, int width, int height) {

        }

        @Override
        public void surfaceDestroyed(@NonNull SurfaceHolder holder) {

        }




    }
