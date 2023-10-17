package com.example.enlazar_formularios;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class InicioSesion extends AppCompatActivity implements View.OnClickListener{


    private View boton1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        boton1 = findViewById(R.id.boton1);
        boton1.setOnClickListener(this);

        //Bundle bundle = getIntent().getExtras();

    }


    public void onClick(View view) {

        if (view.getId() == R.id.boton1) {

            Intent i = new Intent(InicioSesion.this, MainActivity2.class);
            startActivity(i);
            finish();

        }
    }

}