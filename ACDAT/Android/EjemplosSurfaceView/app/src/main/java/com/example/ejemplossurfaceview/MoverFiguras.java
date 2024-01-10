package com.example.ejemplossurfaceview;

import android.content.Context;
import android.graphics.Canvas;
import android.view.MotionEvent;
import android.view.SurfaceView;

public class MoverFiguras extends SurfaceView {

    public MoverFiguras(Context context) {
        super(context);
    }

    public void onDraw(Canvas canvas)
    {

    }

    public boolean onTouchEvent(MotionEvent event)
    {
        return true;
    }


}