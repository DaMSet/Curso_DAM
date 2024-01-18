package com.example.examenrecuperacionandroiddavidms;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

import com.example.examenrecuperacionandroiddavidms.POJOS.Citas;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Map;
import java.util.Random;

public class citaDelDia extends AppCompatActivity {
    private ArrayList<String> listaNombreCitas;

    private TextView textViewCita;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cita_del_dia);

        textViewCita = findViewById(R.id.textViewCita);


        String l = listaNombreCitas.get(1);

        textViewCita.setText(l);
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