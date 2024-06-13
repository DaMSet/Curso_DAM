package com.example.ejemploconexionsqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    daoContacto dao ;
    Adaptador adaptador;
    ArrayList<Contacto> lista;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //setContentView(R.layout.activity_item);
        dao = new daoContacto(this);
        lista = dao.verTodos();
        adaptador = new Adaptador(lista,this,dao);

        ListView List = (ListView) findViewById(R.id.)

    }
}