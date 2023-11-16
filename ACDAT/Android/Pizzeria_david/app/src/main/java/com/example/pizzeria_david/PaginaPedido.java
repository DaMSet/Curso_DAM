package com.example.pizzeria_david;


import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;

import com.example.pizzeria_david.databinding.ActivityPaginaPedidoBinding;
import com.example.pizzeria_david.databinding.ActivityPaginaPrincipalBinding;


public class PaginaPedido extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasPedido,btnPizzasPredeterminadas,btnCrearPizzas,bntUltimoPedido,pantalla;
    private ActivityPaginaPedidoBinding binding;

    private boolean ultimoPedido,pedidoRealizado;

    private PreferenciasCompartidas sharedPreferencesManager;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_pedido);


        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        binding = ActivityPaginaPedidoBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        btnAtrasPedido = binding.btnAtrasPedido;
        btnAtrasPedido.setOnClickListener(this);

        btnPizzasPredeterminadas = binding.btnPizzasPredeterminadas;
        btnPizzasPredeterminadas.setOnClickListener(this);

        btnCrearPizzas = binding.btnCrearPizzas;
        btnCrearPizzas.setOnClickListener(this);

        bntUltimoPedido = binding.btnUltimoPedido;
        bntUltimoPedido.setOnClickListener(this);


        pantalla = binding.paginapedido1;


        cargarPreferencias();

        if (ultimoPedido) {
            bntUltimoPedido.setVisibility(View.VISIBLE);
        }

    }




    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasPedido) {


            Intent i = new Intent(PaginaPedido.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }


        if (view.getId() == R.id.btnPizzasPredeterminadas) {


            Intent i = new Intent(PaginaPedido.this, PaginaPizzasPredeterminadas.class);
            startActivity(i);
            finish();


        }

        if (view.getId() == R.id.btnCrearPizzas) {


            Intent i = new Intent(PaginaPedido.this, PaginaCrearPizzas.class);
            startActivity(i);
            finish();


        }

    }

    private void cargarPreferencias(){


        String fondo = sharedPreferencesManager.obtenerDato("background","pizza_claro.jpg");



        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            pantalla.setBackgroundResource(R.drawable.pizza_claro);
        }
        else
        {
            pantalla.setBackgroundResource(R.drawable.pizza_oscuro);
        }

        ultimoPedido = sharedPreferencesManager.obtenerDatoBoolean("UltimoPedido",false);
        pedidoRealizado = sharedPreferencesManager.obtenerDatoBoolean("PedidoRealizado",false);


    }
}