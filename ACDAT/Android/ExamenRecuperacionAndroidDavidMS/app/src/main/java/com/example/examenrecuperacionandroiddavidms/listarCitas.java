package com.example.examenrecuperacionandroiddavidms;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;

import com.example.examenrecuperacionandroiddavidms.POJOS.Citas;
import com.example.examenrecuperacionandroiddavidms.SERVICIO.Servicio;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

public class listarCitas extends AppCompatActivity {


    private Servicio servicio;
    private Map<Citas, Citas> citas;
    private ListView listView;
    private EditText editTextTextMultiLine;

    private ArrayList<String> listaNombreCitas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_listar_citas);

        servicio = Servicio.getInstance(this);
        citas = servicio.getCitas();

        listView = findViewById(R.id.listViewCitas);

        editTextTextMultiLine = findViewById(R.id.editTextTextMultiLine);


    }

    public void mostrarCitas(Map<Citas,Citas > citas){

        listaNombreCitas = new ArrayList<>();


        Iterator<Map.Entry<Citas, Citas>> iterator = citas.entrySet().iterator();

        while (iterator.hasNext()) {
            Map.Entry<Citas, Citas> entry = iterator.next();
            Citas value = entry.getValue();

            String strNombreCita = value.getCita().toUpperCase();
            listaNombreCitas.add(strNombreCita);
           // editTextTextMultiLine.append(strNombreCita);
        }

        //editTextTextMultiLine.setText(listaNombreCitas);

        /*
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, listaNombreCitas) {

        };*/





    }

}