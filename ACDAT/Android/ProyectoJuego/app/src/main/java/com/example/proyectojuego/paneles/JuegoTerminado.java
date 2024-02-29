package com.example.proyectojuego.paneles;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;

import androidx.core.content.ContextCompat;

import com.example.proyectojuego.R;


//Este es el panel que se dibujara cuando el juego termine

public class JuegoTerminado {

    private Context context;

    public JuegoTerminado(Context context){
        this.context = context;
    }

    public void draw(Canvas canvas){
        String texto = "Game Over";

        float x = 800;
        float y = 200;

        Paint paint = new Paint();
        int color = ContextCompat.getColor(context, R.color.juegoTerminado);
        paint.setColor(color);
        float tamañoTexto = 150;
        paint.setTextSize(tamañoTexto);

        canvas.drawText(texto,x,y,paint);

    }


}
