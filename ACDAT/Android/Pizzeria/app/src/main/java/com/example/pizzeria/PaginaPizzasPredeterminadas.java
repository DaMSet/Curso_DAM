package com.example.pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class PaginaPizzasPredeterminadas extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasPaginaPizzasPredeterminadas;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_pizzas_predeterminadas);

        btnAtrasPaginaPizzasPredeterminadas = findViewById(R.id.btnAtrasPaginaPizzasPredeterminadas);
        btnAtrasPaginaPizzasPredeterminadas.setOnClickListener(this);

    }


    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasCrearPizzas) {


            Intent i = new Intent(PaginaPizzasPredeterminadas.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }
    }

}