package com.example.pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;

public class PaginaConfiguracion extends AppCompatActivity implements View.OnClickListener {

    private View btnAtrasConfig;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_configuracion);

        btnAtrasConfig = findViewById(R.id.btnAtrasConfig);
        btnAtrasConfig.setOnClickListener(this);

    }

    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnConfiguracion) {

            Intent i = new Intent(PaginaConfiguracion.this, PaginaPrincipal.class);
            startActivity(i);
            finish();

        }
    }
}