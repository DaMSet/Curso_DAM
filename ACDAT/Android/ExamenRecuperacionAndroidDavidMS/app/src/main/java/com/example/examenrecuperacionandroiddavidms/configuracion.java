package com.example.examenrecuperacionandroiddavidms;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.widget.RadioButton;

public class configuracion extends AppCompatActivity {

    private RadioButton rbt1,rbt2,rbt3;
    private int valor;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_configuracion);

        rbt1  = findViewById(R.id.rbt1);
        rbt2  = findViewById(R.id.rbt2);
        rbt3  = findViewById(R.id.rbt3);



        if (rbt1.isChecked()) {

            valor = 1;

        } else if (rbt2.isChecked()) {
            valor = 2;

        }else if (rbt3.isChecked()) {
            valor = 3;
        }

    }



    @Override
    protected void onResume() {
        super.onResume();
        SharedPreferences sharedPref = getSharedPreferences("citasDia", Context.MODE_PRIVATE);
        valor = sharedPref.getInt("citasDia", 1);

        if (valor == 1) {

            valor = sharedPref.getInt("citasDia", 1);

        } else if (valor == 2) {
            valor = sharedPref.getInt("citasDia", 2);

        }else if (valor == 3) {
            valor = sharedPref.getInt("citasDia", 3);
        }
    }

}