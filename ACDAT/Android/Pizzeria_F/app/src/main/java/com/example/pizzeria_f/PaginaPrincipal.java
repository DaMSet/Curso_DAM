package com.example.pizzeria_f;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class PaginaPrincipal extends AppCompatActivity implements View.OnClickListener{

    private View btnAtras,btnWeb,btnPedido,btnConfiguracion;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_principal);

        btnAtras = findViewById(R.id.btnAtras);
        btnAtras.setOnClickListener(this);

        btnWeb = findViewById(R.id.btnWeb);
        btnWeb.setOnClickListener(this);

        btnPedido = findViewById(R.id.btnPedido);
        btnPedido.setOnClickListener(this);

        btnConfiguracion = findViewById(R.id.btnConfiguracion);
        btnConfiguracion.setOnClickListener(this);

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

            Intent i = new Intent(PaginaPrincipal.this, MainActivity.class);
            startActivity(i);
            finish();

        }

    }


}