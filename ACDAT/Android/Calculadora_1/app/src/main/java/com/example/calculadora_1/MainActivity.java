package com.example.calculadora_1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    Button boton1,boton2,boton3;
    TextView texto;
    public static int contador = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        //texto = findViewById(R.id.texto);

        boton1 = findViewById(R.id.boton1);
        boton1.setOnClickListener(this);

        boton2 = findViewById(R.id.boton2);
        boton2.setOnClickListener(this);

        boton3 = findViewById(R.id.boton3);
        boton3.setOnClickListener(this);

    }

    @Override
    public void onClick(View view) {

        texto = findViewById(R.id.Texto);

        if(R.id.boton1==view.getId())
        {
            contador++;
        }else if(R.id.boton2==view.getId())
        {
            contador--;
        }else if(R.id.boton3==view.getId())
        {
            contador = 0;
        }

        texto.setText(""+contador);

    }


}