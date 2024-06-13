package com.example.libreria_consqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class UpdateActivity extends AppCompatActivity {

    EditText txtTituloModificar,txtAutorModificar,txtNPaginasModificar;
    Button btn_Update;

    String id,title,author,pages;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update);

        txtTituloModificar = findViewById(R.id.txtTituloModificar);
        txtAutorModificar = findViewById(R.id.txtAutorModificar);
        txtNPaginasModificar = findViewById(R.id.txtNPaginasModificar);

        btn_Update = findViewById(R.id.btn_Update);
        //Primero obtenemos los datos
        getAndSetIntentData();
        btn_Update.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                MyDatabaseHelper myBD = new MyDatabaseHelper(UpdateActivity.this);
                //Y solo despues actualizamos los datos
                title=txtTituloModificar.getText().toString().trim();
                author=txtAutorModificar.getText().toString().trim();
                pages=txtNPaginasModificar.getText().toString().trim();
                myBD.updateData(id,title,author,pages);

            }
        });




    }


    void getAndSetIntentData(){

        if(getIntent().hasExtra("id") && getIntent().hasExtra("title") &&
                getIntent().hasExtra("author") && getIntent().hasExtra("pages")){
            //SACAMOS LOS DATOS DEL INTENT
            id = getIntent().getStringExtra("id");
            title = getIntent().getStringExtra("title");
            author = getIntent().getStringExtra("author");
            pages = getIntent().getStringExtra("pages");

            //PONEMOS LOS DATOS AL INTENT

            txtTituloModificar.setText(title);
            txtAutorModificar.setText(author);
            txtNPaginasModificar.setText(pages);


        }else {
            Toast.makeText(this,"no data", Toast.LENGTH_SHORT).show();
        }

    }




}