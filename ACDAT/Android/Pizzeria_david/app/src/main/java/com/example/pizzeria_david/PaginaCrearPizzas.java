package com.example.pizzeria_david;


import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.pizzeria_david.databinding.ActivityMainBinding;
import com.example.pizzeria_david.databinding.ActivityPaginaCrearPizzasBinding;


public class PaginaCrearPizzas extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasCrearPizzas,paginacrearpizzas;
    private ActivityPaginaCrearPizzasBinding binding;
    private PreferenciasCompartidas sharedPreferencesManager;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_crear_pizzas);


        binding = ActivityPaginaCrearPizzasBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        btnAtrasCrearPizzas = binding.btnAtrasCrearPizzas;

        btnAtrasCrearPizzas.setOnClickListener(this);

        paginacrearpizzas = binding.paginacrearpizzas1;

        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        cargarPreferencias();

    }

    private void cargarPreferencias() {
        String fondo = sharedPreferencesManager.obtenerDato("background","pizza_claro.jpg");


        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            paginacrearpizzas.setBackgroundResource(R.drawable.pizza_claro);
        }
        else
        {
            paginacrearpizzas.setBackgroundResource(R.drawable.pizza_oscuro);
        }
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
