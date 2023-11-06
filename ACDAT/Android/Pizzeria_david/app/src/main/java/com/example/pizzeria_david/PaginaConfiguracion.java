package com.example.pizzeria_david;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;


import com.example.pizzeria_david.databinding.ActivityPaginaConfiguracionBinding;

public class PaginaConfiguracion extends AppCompatActivity implements View.OnClickListener {

    private View btnAtrasConfig,swcColor,swcUltimoPedido,spColores;

    private ActivityPaginaConfiguracionBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_configuracion);

       // btnAtrasConfig = findViewById(R.id.btnAtrasConfig);


        binding = ActivityPaginaConfiguracionBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        btnAtrasConfig = binding.btnAtrasConfig;
        btnAtrasConfig.setOnClickListener(this);

        swcColor = binding.swcColor;
        swcColor.setOnClickListener(this);

        swcUltimoPedido = binding.swcUltimoPedido;
        swcUltimoPedido.setOnClickListener(this);

        spColores = binding.spColores;
        spColores.setVisibility(View.INVISIBLE);

    }

    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasConfig) {

            Intent i = new Intent(PaginaConfiguracion.this, PaginaPrincipal.class);
            startActivity(i);
            finish();

        }


        if (view.getId() == R.id.swcColor){


            if (swcColor.createAccessibilityNodeInfo().isChecked())
            {
                spColores.setVisibility(View.VISIBLE);
            }
            else
            {
                spColores.setVisibility(View.INVISIBLE);
            }

        }


    }
}