package com.example.pizzeria_david;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;
import android.widget.Switch;


import com.example.pizzeria_david.databinding.ActivityPaginaConfiguracionBinding;

public class PaginaConfiguracion extends AppCompatActivity implements View.OnClickListener {

    private View btnAtrasConfig,spColores,paginaConfiguracion;
    private Switch swcColor,swcUltimoPedido;
    private ActivityPaginaConfiguracionBinding binding;

    private PreferenciasCompartidas sharedPreferencesManager;
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

        paginaConfiguracion = binding.paginaConfiguracion1;


        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        cargarPreferencias();

    }

    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasConfig) {

            Intent i = new Intent(PaginaConfiguracion.this, PaginaPrincipal.class);
            startActivity(i);
            finish();

        }


        if (view.getId() == R.id.swcColor){

/*
            if (swcColor.createAccessibilityNodeInfo().isChecked())
            {
                spColores.setVisibility(View.VISIBLE);
            }
            else
            {
                spColores.setVisibility(View.INVISIBLE);
            }
*/
            if (swcColor.createAccessibilityNodeInfo().isChecked())
            {
                swcColor.setText("Claro");
                guardarPreferenciasFondo(swcColor.getText().toString());
                cargarPreferencias();
            }
            else
            {
                swcColor.setText("Oscuro");
                guardarPreferenciasFondo(swcColor.getText().toString());
                cargarPreferencias();
            }

        }

        if (view.getId() == R.id.swcUltimoPedido)
        {

            if (swcUltimoPedido.createAccessibilityNodeInfo().isChecked())
            {
                swcUltimoPedido.setText("SI");
                guardarPreferenciasUltimoPedido(true);
                cargarPreferencias();
            }
            else
            {
                swcUltimoPedido.setText("NO");
                guardarPreferenciasUltimoPedido(false);
                cargarPreferencias();
            }

        }


    }

    private void guardarPreferenciasFondo(String tipoFondo){

        String fondo = "";


        
        //Añadimos el fondo Predeterminado
        if(tipoFondo.equalsIgnoreCase("Claro"))
        {
             fondo = "pizza_claro.jpg";
        }
        else if (tipoFondo.equalsIgnoreCase("Oscuro"))
        {
             fondo = "pizza_oscuro.jpg";
        }

        sharedPreferencesManager.guardarDatoString("background",fondo);

    }

    private void guardarPreferenciasUltimoPedido(boolean valor){

            sharedPreferencesManager.guardarDatoBoolean("UltimoPedido",valor);

    }

    private void cargarPreferencias(){

        String fondo = sharedPreferencesManager.obtenerDato("background","pizza_claro.jpg");

        boolean UltimoPedido = sharedPreferencesManager.obtenerDatoBoolean("UltimoPedido",false);

        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            paginaConfiguracion.setBackgroundResource(R.drawable.pizza_claro);
            swcColor.setText("claro");
            swcColor.setChecked(true);
        }
        else
        {
            paginaConfiguracion.setBackgroundResource(R.drawable.pizza_oscuro);
            swcColor.setText("oscuro");
            swcColor.setChecked(false);
        }

        if(UltimoPedido)
        {
            swcUltimoPedido.setText("SI");
            swcUltimoPedido.setChecked(true);
        }
        else
        {
            swcUltimoPedido.setText("NO");
            swcUltimoPedido.setChecked(false);
        }




    }

}