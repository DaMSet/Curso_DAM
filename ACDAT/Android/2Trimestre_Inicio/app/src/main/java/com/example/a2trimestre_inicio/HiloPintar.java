package com.example.a2trimestre_inicio;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class HiloPintar extends Thread{

    private SurfaceHolder sh;
    private Main view;
    private boolean run;

    public HiloPintar(SurfaceHolder sh, Main view)
    {

        this.sh = sh;
        this.view = view;
        run = false;

    }

    public void setRunning(boolean run) {        this.run = run;    }


    public void run()
    {

        Canvas canvas = null;
        view.draw(canvas);

    }

}
