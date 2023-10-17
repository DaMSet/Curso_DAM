package com.example.enlazar_formularios;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity2 extends AppCompatActivity implements View.OnClickListener{


    private View boton2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);


        boton2 = findViewById(R.id.boton2);
        boton2.setOnClickListener(this);

    }


    public void onClick(View view) {

        if (view.getId() == R.id.boton2) {

            Intent i = new Intent(MainActivity2.this, InicioSesion.class);
            startActivity(i);

        }
    }


}