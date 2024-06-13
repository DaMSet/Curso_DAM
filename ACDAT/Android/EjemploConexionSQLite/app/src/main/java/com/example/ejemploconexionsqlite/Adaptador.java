package com.example.ejemploconexionsqlite;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.TextView;

import java.util.ArrayList;

public class Adaptador extends BaseAdapter {

    ArrayList<Contacto> Lista;
    daoContacto dao;
    Contacto contacto;

    Activity activity;

    public Adaptador(ArrayList<Contacto> Lista, Activity activity, daoContacto dao) {

        this.Lista = Lista;
        this.activity = activity;
        this.dao = dao;

    }


    @Override
    public int getCount() {
        return Lista.size();
    }

    @Override
    public Contacto getItem(int i) {
        contacto = Lista.get(i);

        return contacto;
    }

    @Override
    public long getItemId(int i) {

        contacto = Lista.get(i);

        return contacto.getId();
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        View v = convertView;

        if(v!= null){
            LayoutInflater li = (LayoutInflater) activity.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            v = li.inflate(R.layout.activity_item,null);
        }

        contacto = Lista.get(position);

        TextView nombre = v.findViewById(R.id.textNombre);
        TextView telefono = v.findViewById(R.id.textTelefono);
        TextView  email = v.findViewById(R.id.textEmail);
        TextView edad = v.findViewById(R.id.textEdad);

        Button eliminar = v.findViewById(R.id.delete);
        Button editar = v.findViewById(R.id.edit);

        nombre.setText(contacto.getNombre());
        telefono.setText(contacto.getTelefono());
        email.setText(contacto.getEmail());
        edad.setText(contacto.getEdad());

        editar.setTag(position);
        eliminar.setTag(position);

        editar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });

        eliminar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });

        return v;
    }
}
