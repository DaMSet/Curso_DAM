package com.example.pizzeria_david;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.pizzeria_david.databinding.ActivityPaginaPedidoBinding;
import com.example.pizzeria_david.databinding.ActivityPaginaPizzasPredeterminadasBinding;

public class PaginaPizzasPredeterminadas extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasPaginaPizzasPredeterminadas,btnCarrito,pantallapaginapizzaspredeterminadas;


    private View prueba1;
    private View prueba2;

    private boolean bool = true;
    private PreferenciasCompartidas sharedPreferencesManager;

    private ActivityPaginaPizzasPredeterminadasBinding binding;

    private RecyclerView recyclerviewPizzas;
    private MyAdaptador adaptador;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_pizzas_predeterminadas);

        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        binding = ActivityPaginaPizzasPredeterminadasBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        btnAtrasPaginaPizzasPredeterminadas = binding.btnAtrasPaginaPizzasPredeterminadas;
        btnAtrasPaginaPizzasPredeterminadas.setOnClickListener(this);

        btnCarrito = binding.btnSiguiente;
        btnCarrito.setOnClickListener(this);

        prueba1 = binding.editTextText2;
        prueba2 = binding.editTextText3;

        prueba1.setVisibility(View.GONE);

        recyclerviewPizzas = binding.reciclerviewPizzas;

        recyclerviewPizzas.setLayoutManager(new LinearLayoutManager(this));

        pantallapaginapizzaspredeterminadas = binding.paginapizzaspredeterminadas1;
        cargarPreferencias();





    }


    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasPaginaPizzasPredeterminadas) {


            Intent i = new Intent(PaginaPizzasPredeterminadas.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }

        if (view.getId() == R.id.btnSiguiente) {



            mostrarTipoPizzas(bool);

            bool = !bool;

        }




    }


    private void mostrarTipoPizzas(boolean b)
    {

        this.prueba1.setVisibility(b? View.VISIBLE:View.GONE);
        this.prueba2.setVisibility(b? View.GONE:View.VISIBLE);

    }


    private void cargarPreferencias(){


        String fondo = sharedPreferencesManager.obtenerDato("background","pizza_claro.jpg");



        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            pantallapaginapizzaspredeterminadas.setBackgroundResource(R.drawable.pizza_claro);
        }
        else
        {
            pantallapaginapizzaspredeterminadas.setBackgroundResource(R.drawable.pizza_oscuro);
        }




    }

}