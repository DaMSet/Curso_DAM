package com.example.examen;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.examen.databinding.ActivityDificultadBinding;
import com.example.examen.databinding.ActivityMainBinding;

public class Dificultad extends AppCompatActivity implements View.OnClickListener{

    private ActivityDificultadBinding binding;
    private PreferenciasCompartidas sharedPreferencesManager;

    private View btnSalir,btnFacil,btnMedio,btnDificil;


    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_configuracion);

        // btnAtrasConfig = findViewById(R.id.btnAtrasConfig);


        binding = ActivityDificultadBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());


        btnFacil = binding.btnFacil;
        btnFacil.setOnClickListener(this);

        btnMedio = binding.btnMedio;
        btnMedio.setOnClickListener(this);

        btnDificil = binding.btnDificil;
        btnDificil.setOnClickListener(this);

        btnSalir = binding.btnSalirDificultad;
        btnSalir.setOnClickListener(this);

        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        //cargarPreferencias();

    }

    @Override
    public void onClick(View view) {


        if (view.getId() == R.id.btnSalir) {

            Intent i = new Intent(Dificultad.this, MainActivity.class);
            startActivity(i);
            finish();

        }

        if (view.getId() == R.id.btnFacil) {



        }

        if (view.getId() == R.id.btnMedio) {



        }

        if (view.getId() == R.id.btnDificil) {



        }


    }
}