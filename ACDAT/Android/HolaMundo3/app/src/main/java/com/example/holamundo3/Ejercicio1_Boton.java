package com.example.holamundo3;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Ejercicio1_Boton extends AppCompatActivity  implements  View.OnClickListener{

    private static int num = 0;
    private TextView texto = (TextView) findViewById(R.id.CajaTexto);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ejercicio1_boton);



        Button btnPulsar = findViewById(R.id.PulsaBoton);
        btnPulsar.setOnClickListener(this::onClick);

        Button btn1 = findViewById(R.id.btn1);
        btn1.setOnClickListener(this::onClick);

        Button btn2 = findViewById(R.id.btn2);
        btn2.setOnClickListener(this::onClick);


        //TextView texto = (TextView) findViewById(R.id.CajaTexto);


    }

    @Override
    public void onClick(View view){


        if (view.getId()==R.id.btn1)
        {
            num++;
            texto.setText(num + "");

        }
        if (view.getId()==R.id.PulsaBoton)
        {
            num = 0;
            texto.setText(num+ "");

        }
        if (view.getId()==R.id.btn2)
        {
            num--;
            texto.setText(num+ "");

        }




    }


}