package com.example.pizzeria_david;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.pizzeria_david.databinding.ActivityPaginaPrincipalBinding;

public class PaginaPrincipal extends AppCompatActivity implements View.OnClickListener{

    private View btnAtras,btnWeb,btnPedido,btnConfiguracion,paginaprincipal;

    private ActivityPaginaPrincipalBinding binding;

    private PreferenciasCompartidas sharedPreferencesManager;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_principal);

        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        binding = ActivityPaginaPrincipalBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        btnAtras = binding.btnAtras;
        //btnAtras = findViewById(R.id.btnAtras);
        btnAtras.setOnClickListener(this);

        btnWeb = binding.btnWeb;
        //btnWeb = findViewById(R.id.btnWeb);
        btnWeb.setOnClickListener(this);

        btnPedido = binding.btnPedido;
        //btnPedido = findViewById(R.id.btnPedido);
        btnPedido.setOnClickListener(this);

        btnConfiguracion = binding.btnConfiguracion;
       // btnConfiguracion = findViewById(R.id.btnConfiguracion);
        btnConfiguracion.setOnClickListener(this);

        paginaprincipal = binding.paginaprincipal1;

        cargarPreferencias();

    }




    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtras) {

            Intent i = new Intent(PaginaPrincipal.this, MainActivity.class);
            startActivity(i);
            finish();


        }

        if (view.getId() == R.id.btnWeb) {

            Intent i = new Intent(PaginaPrincipal.this, PaginaWeb.class);
            startActivity(i);
            finish();

        }

        if (view.getId() == R.id.btnPedido) {

            Intent i = new Intent(PaginaPrincipal.this, PaginaPedido.class);
            startActivity(i);
            finish();

        }

        if (view.getId() == R.id.btnConfiguracion) {

            Intent i = new Intent(PaginaPrincipal.this, PaginaConfiguracion.class);
            startActivity(i);
            finish();

        }

    }

    private void cargarPreferencias(){

        String fondo = sharedPreferencesManager.obtenerDato("background","pizza_claro.jpg");


        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            paginaprincipal.setBackgroundResource(R.drawable.pizza_claro);
        }
        else
        {
            paginaprincipal.setBackgroundResource(R.drawable.pizza_oscuro);
        }




    }

}