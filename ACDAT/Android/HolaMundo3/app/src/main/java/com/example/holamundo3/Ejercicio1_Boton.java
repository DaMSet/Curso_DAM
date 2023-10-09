package com.example.holamundo3;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Ejercicio1_Boton extends AppCompatActivity  implements  View.OnClickListener{


    /////

    private static Ejercicio1_Boton instance;

    public Ejercicio1_Boton(){
        instance = this;
    }

    public static Ejercicio1_Boton getInstance(){
        return  instance;
    }

    public void myMethod(){

    }

    //Ejercicio1_Boton.getInstance().myMethod();


    /////

    private static int num = 0;
    private TextView texto = (TextView) findViewById(R.id.CajaTexto);

    private Button btn1, btn2, PulsaBoton;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ejercicio1_boton);



        PulsaBoton = findViewById(R.id.PulsaBoton);
        PulsaBoton.setOnClickListener(this::onClick);

        btn1 = findViewById(R.id.btn1);
        btn1.setOnClickListener(this::onClick);

        btn2 = findViewById(R.id.btn2);
        btn2.setOnClickListener(this::onClick);





        //TextView texto = (TextView) findViewById(R.id.CajaTexto);


    }

    @Override
    public void onClick(View view){


        if(view.getId() == R.id.btn1)
        {
            num--;
        }

        if(view.getId() == R.id.btn1)
        {
            num--;
        }

        if(view.getId() == R.id.btn1)
        {
            num = 0; // Restablece el contador a 0
        }



        texto.setText("" + num);
        texto.setText("" + num);
        texto.setText("" + num);

    }


}