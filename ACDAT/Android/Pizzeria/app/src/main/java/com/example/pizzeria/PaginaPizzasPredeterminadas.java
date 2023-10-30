package com.example.pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class PaginaPizzasPredeterminadas extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasPaginaPizzasPredeterminadas,btnCarrito;

    private View prueba1;
    private View prueba2;

    private boolean bool = true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_pizzas_predeterminadas);

        btnAtrasPaginaPizzasPredeterminadas = findViewById(R.id.btnAtrasPaginaPizzasPredeterminadas);
        btnAtrasPaginaPizzasPredeterminadas.setOnClickListener(this);

        btnCarrito = findViewById(R.id.btnCarrito);
        btnCarrito.setOnClickListener(this);

        prueba1 = findViewById(R.id.editTextText2);
        prueba2 = findViewById(R.id.editTextText3);

        prueba1.setVisibility(View.GONE);

    }


    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasPaginaPizzasPredeterminadas) {


            Intent i = new Intent(PaginaPizzasPredeterminadas.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }

        if (view.getId() == R.id.btnCarrito) {



            mostrarTipoPizzas(bool);

            bool = !bool;

        }

    }


    private void mostrarTipoPizzas(boolean b)
    {

    this.prueba1.setVisibility(b? View.VISIBLE:View.GONE);
    this.prueba2.setVisibility(b? View.GONE:View.VISIBLE);

    }


}