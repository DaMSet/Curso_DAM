package com.example.pizzeria_david;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.pizzeria_david.databinding.ActivityPaginaPrincipalBinding;

public class PaginaPrincipal extends AppCompatActivity implements View.OnClickListener{

    private View btnAtras,btnWeb,btnPedido,btnConfiguracion;

    private ActivityPaginaPrincipalBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_principal);


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


}