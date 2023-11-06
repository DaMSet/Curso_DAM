package com.example.pizzeria_david;


import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;


public class PaginaCrearPizzas extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasCrearPizzas;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_crear_pizzas);


        btnAtrasCrearPizzas = findViewById(R.id.btnAtrasCrearPizzas);
        btnAtrasCrearPizzas.setOnClickListener(this);

    }


    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasCrearPizzas) {


            Intent i = new Intent(PaginaCrearPizzas.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }


    }





}
