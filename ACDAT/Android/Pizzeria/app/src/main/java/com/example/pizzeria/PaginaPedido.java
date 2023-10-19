package com.example.pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.content.Intent;


public class PaginaPedido extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasPedido;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_pedido);

        btnAtrasPedido = findViewById(R.id.btnAtrasPedido);
        btnAtrasPedido.setOnClickListener(this);


    }




    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasPedido) {


            Intent i = new Intent(PaginaPedido.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }


    }
}