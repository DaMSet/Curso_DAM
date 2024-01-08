package com.example.a2trimestre_inicio;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.graphics.Canvas;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    class RenderView extends View{
        Random rdn = new Random();

        public RenderView(Context context)
        {

            super(context);

        }

        protected void onDraw(Canvas canvas)
        {
            canvas.drawRGB(rdn.nextInt(256),rdn.nextInt(256),rdn.nextInt(256));

        }

    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_main);

        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(new RenderView(this));


    }



}