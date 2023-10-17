package com.example.pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class PaginaPrincipal extends AppCompatActivity implements View.OnClickListener{

    private View atras;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_principal);

        atras = findViewById(R.id.btnAtras);
        atras.setOnClickListener(this);

    }




    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtras) {

            Intent i = new Intent(PaginaPrincipal.this, MainActivity.class);
            startActivity(i);
            //finish();


        }
    }


}