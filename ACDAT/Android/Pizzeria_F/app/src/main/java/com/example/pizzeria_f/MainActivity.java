package com.example.pizzeria_f;


import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import com.example.pizzeria_f.databinding.ActivityMainBinding;


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

        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        inicioSesion = binding.btnInicioSesion;
        //inicioSesion = findViewById(R.id.btnInicioSesion);
        inicioSesion.setOnClickListener(this);

/*
        FirebaseDatabase database = FirebaseDatabase.getInstance("https://pizzeria-a247c-default-rtdb.firebaseio.com/");
        DatabaseReference myRef = database.getReference("message");

        myRef.setValue("Hello, World!");
*/

    }

    public void onClick(View view) {

        if (view.getId() == R.id.btnInicioSesion) {

            Intent i = new Intent(MainActivity.this, PaginaPrincipal.class);
            startActivity(i);
            //finish();

        }
    }



}