package com.example.proyectojuego.paneles;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.R;

public class Puntos {
    private Context context;
    private int punto = 0;

    public Puntos(Context context){
        this.context = context;
    }

    public void draw(Canvas canvas){
        String texto = "Puntos: " + punto;

        float x = 2300;
        float y = 200;

        Paint paint = new Paint();
        int color = ContextCompat.getColor(context, R.color.bala);
        paint.setColor(color);
        float tamañoTexto = 50;
        paint.setTextSize(tamañoTexto);

        canvas.drawText(texto,x,y,paint);

    }

    public int getPunto() {
        return punto;
    }

    public void setPunto(int punto) {
        this.punto = punto;
    }

    public void sumarpunto(){
        this.punto++;
    }

}
