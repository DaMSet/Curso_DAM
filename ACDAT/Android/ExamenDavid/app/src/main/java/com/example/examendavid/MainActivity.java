package com.example.examendavid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import com.example.examendavid.databinding.ActivityMainBinding;


public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    private ActivityMainBinding binding;

    private View btnSalir,btnJugar,btnListar,btnDificultad;
    private EditText textoPalabras;

    private PreferenciasCompartidas sharedPreferencesManager;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_configuracion);

        // btnAtrasConfig = findViewById(R.id.btnAtrasConfig);


        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        btnJugar = binding.btnJugar;
        btnJugar.setOnClickListener(this);

        btnDificultad = binding.btnDificultad;
        btnDificultad.setOnClickListener(this);

        btnListar = binding.btnListarPalabras;
        btnListar.setOnClickListener(this);

        btnSalir = binding.btnSalir;
        btnSalir.setOnClickListener(this);

        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        //cargarPreferencias();


        textoPalabras = binding.TextoPalabras;

        textoPalabras.setText("prueba");

    }


    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnJugar) {

            Intent i = new Intent(MainActivity.this, Dificultad.class);
            startActivity(i);
            finish();

        }


        if (view.getId() == R.id.btnDificultad) {

            Intent i = new Intent(MainActivity.this, Dificultad.class);
            startActivity(i);
            finish();

        }

        if (view.getId() == R.id.btnListarPalabras) {

            Intent i = new Intent(MainActivity.this, Dificultad.class);
            startActivity(i);
            finish();

        }

        if (view.getId() == R.id.btnSalir) {



        }


    }
}