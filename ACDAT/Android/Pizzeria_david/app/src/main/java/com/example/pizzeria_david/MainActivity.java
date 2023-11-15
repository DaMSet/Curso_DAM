package com.example.pizzeria_david;



import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.example.pizzeria_david.databinding.ActivityMainBinding;


//
// COMPROBACION USUARIO/CONTRASEÑA
//
public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    private View inicioSesion,pantalla;
    private TextView nombreUsuario;
    private PreferenciasCompartidas sharedPreferencesManager;


    private ActivityMainBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_main);

        //INICIAMOS NUESTRA CLASE DE PREFERENCIAS
        sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);
/*
        inicioSesion = findViewById(R.id.btnInicioSesion);
        inicioSesion.setOnClickListener(this);
*/

        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        inicioSesion = binding.btnInicioSesion;

        inicioSesion.setOnClickListener(this);

        nombreUsuario = binding.txtNombre;

        pantalla = binding.mainActivity1;

        cargarPreferencias();

    }

    public void onClick(View view) {


        if (view.getId() == R.id.btnInicioSesion) {

            guardarPreferencias();
            Intent i = new Intent(MainActivity.this, PaginaPrincipal.class);
            startActivity(i);
            //finish();

        }
    }


    private void guardarPreferencias(){
        //Creamos el archivo de referencias
/*
        SharedPreferences preferences = getSharedPreferences("CredencialesUsuario", Context.MODE_PRIVATE);

        String usuario = nombreUsuario.getText().toString();

        //Creamos el editor del shared references
        SharedPreferences.Editor editor = preferences.edit();

        //Añadimos el usuario local
        editor.putString("user",usuario);

        //Añadimos el fondo Predeterminado
        String fondo = "pizza_claro.jpg";

        editor.putString("background", fondo);


        editor.commit();
*/

        String usuario = nombreUsuario.getText().toString();
        String fondo = "pizza_claro.jpg";

        sharedPreferencesManager.guardarDatoString("user",usuario);
        sharedPreferencesManager.guardarDatoString("background", fondo);

    }


    private void cargarPreferencias(){

        //Creamos el archivo de referencias
/*
        SharedPreferences preferences = getSharedPreferences("CredencialesUsuario", Context.MODE_PRIVATE);

        String user = preferences.getString("user","Inserte usuario");

        String fondo = preferences.getString("background","pizza_claro.jpg");
*/

        String user = sharedPreferencesManager.obtenerDato("user","Usuario_Default");
        String fondo = sharedPreferencesManager.obtenerDato("background","pizza_claro.jpg");

        nombreUsuario.setText(user);

        //Recojemos el fondo por defecto

        if(fondo.equalsIgnoreCase("pizza_claro.jpg"))
        {
            pantalla.setBackgroundResource(R.drawable.pizza_claro);
        }
        else
        {
            pantalla.setBackgroundResource(R.drawable.pizza_oscuro);
        }




    }



}