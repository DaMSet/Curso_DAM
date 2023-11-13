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

    private View btnAtrasConfig,swcUltimoPedido,spColores,paginaConfiguracion;
    private Switch swcColor;
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

        paginaConfiguracion = binding.paginaConfiguracion1;

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
                guardarPreferencias(swcColor.getText().toString());
                cargarPreferencias();
            }
            else
            {
                swcColor.setText("Oscuro");
                guardarPreferencias(swcColor.getText().toString());
                cargarPreferencias();
            }



        }


    }

    private void guardarPreferencias(String tipoFondo){

        //Creamos el archivo de referencias
        SharedPreferences preferences = getSharedPreferences("CredencialesUsuario", Context.MODE_PRIVATE);

        String fondo = "";

        //Creamos el editor del shared references
        SharedPreferences.Editor editor = preferences.edit();
        
        //Añadimos el fondo Predeterminado
        if(tipoFondo.equalsIgnoreCase("Claro"))
        {
             fondo = "pizza_claro.jpg";
        }
        else if (tipoFondo.equalsIgnoreCase("Oscuro"))
        {
             fondo = "pizza_oscuro.jpg";
        }


        editor.putString("background", fondo);


        editor.commit();

    }

    private void cargarPreferencias(){

        //Creamos el archivo de referencias
        SharedPreferences preferences = getSharedPreferences("CredencialesUsuario", Context.MODE_PRIVATE);

        String fondo = preferences.getString("background","pizza_claro.jpg");



        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            paginaConfiguracion.setBackgroundResource(R.drawable.pizza_claro);
        }
        else
        {
            paginaConfiguracion.setBackgroundResource(R.drawable.pizza_oscuro);
        }




    }

}