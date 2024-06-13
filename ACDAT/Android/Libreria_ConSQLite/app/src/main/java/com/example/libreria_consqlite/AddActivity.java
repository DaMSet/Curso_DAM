package com.example.libreria_consqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class AddActivity extends AppCompatActivity {

    Button boton_atras;

    EditText titulo;
    EditText autor;
    EditText nPaginas;
    Button boton_añadirN;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add);




        titulo = findViewById(R.id.txtTituloModificar);
        autor = findViewById(R.id.txtAutorModificar);
        nPaginas = findViewById(R.id.txtNPaginasModificar);
        boton_añadirN = findViewById(R.id.btn_Update);

        boton_añadirN.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                MyDatabaseHelper myDB = new MyDatabaseHelper(AddActivity.this);

                myDB.addBook(titulo.getText().toString().trim(),autor.getText().toString().trim(),Integer.valueOf(nPaginas.getText().toString().trim()));

            }
        });


        boton_atras = findViewById(R.id.btn_atras2);
        boton_atras.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(AddActivity.this, MainActivity.class);
                startActivity(intent);

            }
        });



    }
}