package com.example.examenrecuperacionandroiddavidms;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.examenrecuperacionandroiddavidms.DAO.DAOcitas;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    private Button btnBorrar, btnInsertar,btnListaCitas,btnCitaDia,btnValorar,btnConfiguracion;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnBorrar = findViewById(R.id.btnBorrar);

        btnBorrar.setOnClickListener(this);

        btnInsertar = findViewById(R.id.btnInsertarCita);

        btnInsertar.setOnClickListener(this);

        btnListaCitas = findViewById(R.id.btnListaCitas);

        btnListaCitas.setOnClickListener(this);

        btnCitaDia = findViewById(R.id.btnCitaDia);

        btnCitaDia.setOnClickListener(this);

        btnValorar = findViewById(R.id.btnValorarCita);

        btnValorar.setOnClickListener(this);

        btnConfiguracion = findViewById(R.id.btnConfiguracion);

        btnConfiguracion.setOnClickListener(this);

    }

    public void onClick(View view) {

        if (view.getId() == R.id.btnBorrar) {

            alertaBorrar();

        }

        if (view.getId() == R.id.btnInsertarCita) {
            Intent i = new Intent(this, insertar.class);
            startActivity(i);
        }

        if (view.getId() == R.id.btnListaCitas) {
            Intent i = new Intent(this, listarCitas.class);
            startActivity(i);
        }

        if (view.getId() == R.id.btnCitaDia) {
            Intent i = new Intent(this, citaDelDia.class);
            startActivity(i);
        }

        if (view.getId() == R.id.btnValorarCita) {
            Intent i = new Intent(this, valorarCita.class);
            startActivity(i);
        }

        if (view.getId() == R.id.btnConfiguracion) {
            Intent i = new Intent(this, configuracion.class);
            startActivity(i);
        }

    }

    @SuppressLint("MissingSuperCall")
    public void onBackPressed() {

        alertaSalida();
    }

    private void alertaSalida(){
        AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);

        builder.setTitle("Salir");
        builder.setMessage("¿Seguro que deseas salir?");

        builder.setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {
                finish();
            }
        });
        builder.setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });

        AlertDialog alertDialog = builder.create();
        alertDialog.show();
    }
    private void alertaBorrar(){
        AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);

        builder.setTitle("Salir");
        builder.setMessage("¿Seguro que deseas Borrar?");

        builder.setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {

                //finish();


            }
        });
        builder.setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });

        AlertDialog alertDialog = builder.create();
        alertDialog.show();
    }


}