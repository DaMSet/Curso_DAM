package com.example.pizzeria_david;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;

import com.example.pizzeria_david.databinding.ActivityMainBinding;


//
// COMPROBACION USUARIO/CONTRASEÑA
//
public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    private View inicioSesion;
    //private TextView nombreUsuario,Contraseña;

    private ActivityMainBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_main);


/*
        inicioSesion = findViewById(R.id.btnInicioSesion);
        inicioSesion.setOnClickListener(this);
*/

        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        inicioSesion = binding.btnInicioSesion;

        inicioSesion.setOnClickListener(this);


    }

    public void onClick(View view) {


        if (view.getId() == R.id.btnInicioSesion) {

            Intent i = new Intent(MainActivity.this, PaginaPrincipal.class);
            startActivity(i);
            //finish();

        }
    }



}