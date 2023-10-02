package com.example.holamundo3;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.TextureView;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_main);



        Button btnSALUDAR = findViewById(R.id.btnSaludar);

        btnSALUDAR.setOnClickListener(this);
        {

        }

        /*
        btnSALUDAR.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                TextView txtMensaje = (TextView) findViewById(R.id.txtSaludo);

                txtMensaje.setText("Se a cambiado el texto");
            }
        });
        */


    }

    @Override
    public void onClick(View view) {

        TextView txtMensaje = (TextView) findViewById(R.id.txtSaludo);

        txtMensaje.setText("da igual");

    }




/*
    public void cambiarMensaje(View view)
    {

        TextView txtMensaje = (TextView) findViewById(R.id.txtSaludo);

        txtMensaje.setText("Se a cambiado el texto");


    }
*/
}