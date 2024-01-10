package com.example.pizzeria_david;


import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.pizzeria_david.databinding.ActivityMainBinding;
import com.example.pizzeria_david.databinding.ActivityPaginaCrearPizzasBinding;

import java.util.HashMap;
import java.util.Map;


public class PaginaCrearPizzas extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasCrearPizzas,btnCrearPizza,paginacrearpizzas;
    private ActivityPaginaCrearPizzasBinding binding;
    private PreferenciasCompartidas sharedPreferencesManager;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_pagina_crear_pizzas);


        binding = ActivityPaginaCrearPizzasBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        btnAtrasCrearPizzas = binding.btnAtrasCrearPizzas;

        btnAtrasCrearPizzas.setOnClickListener(this);

        btnCrearPizza = binding.btnCrearPizza;

        btnCrearPizza.setOnClickListener(this);


        paginacrearpizzas = binding.paginacrearpizzas1;

        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

        cargarPreferencias();

    }

    private void cargarPreferencias() {
        String fondo = sharedPreferencesManager.obtenerDato("background","pizza_claro.jpg");


        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            paginacrearpizzas.setBackgroundResource(R.drawable.pizza_claro);
        }
        else
        {
            paginacrearpizzas.setBackgroundResource(R.drawable.pizza_oscuro);
        }
    }


    public void ejecutarServicio(String URL){

            StringRequest stringRequest = new StringRequest(Request.Method.POST, URL, new Response.Listener<String>() {
                @Override
                public void onResponse(String response) {
                    Toast.makeText(getApplicationContext(), "Operacion Exitosa", Toast.LENGTH_SHORT).show();
                }
            }, new Response.ErrorListener() {
                @Override
                public void onErrorResponse(VolleyError error) {
                    Toast.makeText(getApplicationContext(), error.toString(), Toast.LENGTH_SHORT).show();
                }
            })
            {

                @Override
                protected Map<String, String> getParams() throws AuthFailureError {

                    Map<String,String> parametros = new HashMap<String,String >();

                    parametros.put("nombre","prueba1");
                    parametros.put("tamaño","NORMAL");
                    parametros.put("masa","PESADA");
                    parametros.put("precio","20");
                    parametros.put("disponibilidad","1");

                    return parametros;
                }
            };

        RequestQueue requestQueue = Volley.newRequestQueue(this);

        requestQueue.add(stringRequest);

    }

    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasCrearPizzas) {


            Intent i = new Intent(PaginaCrearPizzas.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }

        if (view.getId() == R.id.btnCrearPizza)
        {


            ejecutarServicio("http://192.168.0.17:80/apacheDavid/insertarPizza.php");

        }


    }





}
