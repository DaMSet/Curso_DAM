package com.example.pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;


public class PaginaPedido extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasPedido,btnPizzasPredeterminadas,btnCrearPizzas;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_pedido);

        btnAtrasPedido = findViewById(R.id.btnAtrasPedido);
        btnAtrasPedido.setOnClickListener(this);

        btnPizzasPredeterminadas = findViewById(R.id.btnPizzasPredeterminadas);
        btnPizzasPredeterminadas.setOnClickListener(this);

        btnCrearPizzas = findViewById(R.id.btnCrearPizzas);
        btnCrearPizzas.setOnClickListener(this);

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
}
/*
//Grabar
sharedPreferences

Preferencias = getSharedPreferences("Nombre_archivo", Context.MODE_PRIVATE);

Editor editor = preferencias.edit();

editor.putString("Tamaño",et1.getText().toString());
editor.commit();


//Mostrar

et1 = (EditText)findviewByid(R.id.et1);

SharedPreferences

prefe = getSharedPreferences("nombre_Archivo",Context.MODE_PRIVATE);

et1.setText(prefe.getString("tamaño",""));
*/
