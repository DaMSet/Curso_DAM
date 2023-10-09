package com.example.calculadora;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }


    private Button boton1, boton2, boton3;
    private int contador = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        boton1 = findViewById(R.id.boton1);
        boton2 = findViewById(R.id.boton2);
        boton3 = findViewById(R.id.boton3);
    }

    public void onClickBoton(View view) {

    }


    @Override
    public void onClick(View view) {

        // Determina cuál botón se ha presionado
        switch (view.getId()) {
            case R.id.boton1:
                contador++; // Incrementa el contador
                break;
            case R.id.boton2:
                contador--; // Decrementa el contador
                break;
            case R.id.boton3:
                contador = 0; // Restablece el contador a 0
                break;
        }

        // Actualiza el texto de los botones con el valor del contador
        boton1.setText("" + contador);
        boton2.setText("" + contador);
        boton3.setText("" + contador);

    }
}