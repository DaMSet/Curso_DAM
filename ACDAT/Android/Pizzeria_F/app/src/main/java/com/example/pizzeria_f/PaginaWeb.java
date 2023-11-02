package com.example.pizzeria_f;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.content.Intent;
import android.view.View;

public class PaginaWeb extends AppCompatActivity implements View.OnClickListener{

    private View btnAtrasWeb;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_web);

        btnAtrasWeb = findViewById(R.id.btnAtrasWeb);
        btnAtrasWeb.setOnClickListener(this);


    }




    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnAtrasWeb) {


            Intent i = new Intent(PaginaWeb.this, PaginaPrincipal.class);
            startActivity(i);
            finish();


        }


    }

}