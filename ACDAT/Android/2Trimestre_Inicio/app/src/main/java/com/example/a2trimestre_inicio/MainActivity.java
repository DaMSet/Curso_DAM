package com.example.a2trimestre_inicio;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.FrameLayout;
import android.widget.TextView;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    TextView textView;

    StringBuilder builder = new StringBuilder();

    public boolean onTouch(View v, MotionEvent event)
    {
        builder.setLength(0);
        switch (event.getAction())
        {

        }
    }

    class RenderView extends View{
        Random rdn = new Random();
        Paint paint = new Paint();




        public RenderView(Context context)
        {

            super(context);
            textView = new TextView(context);


        }

        protected void onDraw(Canvas canvas)
        {
            canvas.drawRGB(rdn.nextInt(256),rdn.nextInt(256),rdn.nextInt(256));

            paint.setColor(Color.RED);
            paint.setStrokeWidth(20);
            canvas.drawLine(0,0,canvas.getWidth() -1,canvas.getHeight() -1,paint);

            paint.setStyle(Paint.Style.STROKE);
            paint.setColor(0xff00ff00);
            canvas.drawCircle(canvas.getWidth()/2,canvas.getHeight()/2,40,paint);

            paint.setStyle(Paint.Style.FILL);
            paint.setColor(0x7700ff00);
            canvas.drawRect(100,100,200,200,paint);

            //invalidate();
        }

    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_main);

        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,WindowManager.LayoutParams.FLAG_FULLSCREEN);
        //setContentView(new RenderView(this));

        FrameLayout frameLayout = new FrameLayout(this);
        RenderView renderView = new RenderView(this);
        frameLayout.addView(renderView);

        textView = new TextView(this);
        textView.setText("desliza el dedo");
        textView.setOnTouchListener();
        frameLayout.addView(textView);


        setContentView(frameLayout);

    }



}