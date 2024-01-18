package com.example.examenrecuperacionandroiddavidms;

import static com.example.examenrecuperacionandroiddavidms.R.id.btnInsertar1;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.examenrecuperacionandroiddavidms.SERVICIO.Servicio;

public class insertar extends AppCompatActivity implements View.OnClickListener{

    private EditText editTextCita,editTextAutor,editTextnVeces,editTextValoracion;
    private Button btnInsertar1;
    private Servicio servicio;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_insertar);

        editTextCita = findViewById(R.id.editTextCita);
        editTextAutor = findViewById(R.id.editTextAutor);
        editTextnVeces = findViewById(R.id.editTextnVeces);
        editTextValoracion = findViewById(R.id.editTextValoracion);


        btnInsertar1 = findViewById(R.id.btnInsertar1);

        btnInsertar1.setOnClickListener(this);

        btnInsertar1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                servicio.anadirCita(editTextCita.getText().toString(),editTextAutor.getText().toString(), Integer.parseInt(editTextnVeces.getText().toString()),editTextValoracion.getText().toString());
                finish();
            }
        });

    }




    @Override
    public void onClick(View view) {



    };

}