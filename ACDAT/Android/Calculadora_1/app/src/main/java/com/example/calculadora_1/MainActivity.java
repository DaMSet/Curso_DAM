package com.example.calculadora_1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    //Button boton1,boton2,boton3;
    TextView Pantalla ;
    public static int contador = 0;
    private View btn0,btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btnCOMA,btnMC,btnMmas,btnMmenos,btnMR,btnINTRO,btnC,btnPORCENTAJE,btnDIVISION,btnX;
    static String texto = "";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        /*

        boton1 = findViewById(R.id.boton1);
        boton1.setOnClickListener(this);

        boton2 = findViewById(R.id.boton2);
        boton2.setOnClickListener(this);

        boton3 = findViewById(R.id.boton3);
        boton3.setOnClickListener(this);
*/

        btn0 = findViewById(R.id.btn0);
        btn0.setOnClickListener(this);

        btn1 = findViewById(R.id.btn1);
        btn1.setOnClickListener(this);

        btn2 = findViewById(R.id.btn2);
        btn2.setOnClickListener(this);

        btn3 = findViewById(R.id.btn3);
        btn3.setOnClickListener(this);

        btn4 = findViewById(R.id.btn4);
        btn4.setOnClickListener(this);

        btn5 = findViewById(R.id.btn5);
        btn5.setOnClickListener(this);

        btn6 = findViewById(R.id.btn6);
        btn6.setOnClickListener(this);

        btn7 = findViewById(R.id.btn7);
        btn7.setOnClickListener(this);

        btn8 = findViewById(R.id.btn8);
        btn8.setOnClickListener(this);

        btn9 = findViewById(R.id.btn9);
        btn9.setOnClickListener(this);


        btnC = findViewById(R.id.btnMC);
        btnC.setOnClickListener(this);

        btnCOMA = findViewById(R.id.btnCOMA);
        btnCOMA.setOnClickListener(this);

        btnPORCENTAJE = findViewById(R.id.btnPORCENTAJE);
        btnPORCENTAJE.setOnClickListener(this);

        btnDIVISION = findViewById(R.id.btnMmenos);
        btnDIVISION.setOnClickListener(this);

        btnX = findViewById(R.id.btnX);
        btnX.setOnClickListener(this);

        btnINTRO = findViewById(R.id.btnINTRO);
        btnINTRO.setOnClickListener(this);

        Pantalla = findViewById(R.id.Pantalla);


    }

    @Override
    public void onClick(View view) {


        double tempNum = 0;


        if(view.getId() == R.id.btn0)
        {

            texto += "0";

        }else if(view.getId() == R.id.btn1)
        {

            texto += "1";

        }else if(view.getId() == R.id.btn2)
        {

            texto += "2";

        }else if(view.getId() == R.id.btn3)
        {

            texto += "3";

        }else if(view.getId() == R.id.btn4)
        {

            texto += "4";

        }else if(view.getId() == R.id.btn5)
        {

            texto += "5";

        }else if(view.getId() == R.id.btn6)
        {

            texto += "6";

        }else if(view.getId() == R.id.btn7)
        {

            texto += "7";

        }else if(view.getId() == R.id.btn8)
        {

            texto += "8";

        }else if(view.getId() == R.id.btn9)
        {

            texto += "9";

        }


        Pantalla.setText(""+texto);

        if(view.getId() == R.id.btnINTRO)
        {

            
            //Pantalla.setText(""+texto);

        }





        /*
        if(R.id.boton1==view.getId())
        {
            contador++;
        }else if(R.id.boton2==view.getId())
        {
            contador--;
        }else if(R.id.boton3==view.getId())
        {
            contador = 0;
        }

        texto.setText(""+contador);
        */


    }


}