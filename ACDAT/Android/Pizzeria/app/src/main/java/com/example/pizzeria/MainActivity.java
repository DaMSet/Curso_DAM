package com.example.pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import com.google.firebase.FirebaseApp;
import com.google.firebase.FirebaseOptions;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;


//
// COMPROBACION USUARIO/CONTRASEÑA
//
public class MainActivity extends AppCompatActivity implements View.OnClickListener{

        private View inicioSesion;
        private TextView nombreUsuario,Contraseña;

        @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        inicioSesion = findViewById(R.id.btnInicioSesion);
        inicioSesion.setOnClickListener(this);


            // Inicialización de Firebase
            FirebaseOptions options = new FirebaseOptions.Builder()
                    //.setApplicationId("tu_app_id")
                    //.setApiKey("tu_api_key")
                    .setDatabaseUrl("https://pizzeria-a247c-default-rtdb.firebaseio.com/")
                    .build();
            FirebaseApp.initializeApp(this, options);


            DatabaseReference databaseReference = FirebaseDatabase.getInstance().getReference();

            String userId = "123456";
            String nombre = "John Doe";

            databaseReference.child("usuarios").child(userId).child("nombre").setValue(nombre);



    }

    public void onClick(View view) {

        if (view.getId() == R.id.btnInicioSesion) {

            Intent i = new Intent(MainActivity.this, PaginaPrincipal.class);
            startActivity(i);
            //finish();

        }
    }



}