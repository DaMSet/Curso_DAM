package com.example.calculadora_f;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import net.objecthunter.exp4j.Expression;
import net.objecthunter.exp4j.ExpressionBuilder;


public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    //Button boton1,boton2,boton3;
    TextView Pantalla ;


    public static int contador = 0;
    private View btn0,btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btnCOMA,btnMAS,btnMENOS,btnINTRO,btnC,btnPORCENTAJE,btnDIVISION,btnX;
    static String texto = "";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


/*
        // Crea una instancia del evaluador
        Evaluator evaluator = new Evaluator();

        // Expresión a evaluar
        String expression = "2 + 3 * (5 - 1)";

        try {
            // Evaluar la expresión
            double result = evaluator.evaluate(expression);

            // Hacer algo con el resultado
            // Por ejemplo, mostrarlo en un TextView
            textView.setText("Resultado: " + result);
        } catch (Exception e) {
            // Manejar errores de evaluación
            textView.setText("Error: " + e.getMessage());
        }


*/




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


        btnC = findViewById(R.id.btnC);
        btnC.setOnClickListener(this);

        btnMAS = findViewById(R.id.btnMAS);
        btnMAS.setOnClickListener(this);

        btnMENOS = findViewById(R.id.btnMENOS);
        btnMENOS.setOnClickListener(this);

        btnCOMA = findViewById(R.id.btnCOMA);
        btnCOMA.setOnClickListener(this);

        btnPORCENTAJE = findViewById(R.id.btnPORCENTAJE);
        btnPORCENTAJE.setOnClickListener(this);

        btnDIVISION = findViewById(R.id.btnDIVISION);
        btnDIVISION.setOnClickListener(this);

        btnX = findViewById(R.id.btnX);
        btnX.setOnClickListener(this);

        btnINTRO = findViewById(R.id.btnINTRO);
        btnINTRO.setOnClickListener(this);

        Pantalla = findViewById(R.id.Pantalla);


    }

    @Override
    public void onClick(View view) {


        //double tempNum = 0;



        if(view.getId() == R.id.btnINTRO)
        {

            try {

                ExpressionBuilder constructor = new ExpressionBuilder(texto);
                Expression exp = constructor.build();
                double resultado = exp.evaluate();
                Pantalla.setText(""+resultado);
                texto = ""+resultado;


            }catch(Exception e)
            {
                Pantalla.setText("Error");
                texto = "";
            }

        }else if(view.getId() == R.id.btn0)
        {

            texto += "0";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn1)
        {

            texto += "1";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn2)
        {

            texto += "2";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn3)
        {

            texto += "3";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn4)
        {

            texto += "4";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn5)
        {

            texto += "5";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn6)
        {

            texto += "6";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn7)
        {

            texto += "7";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn8)
        {

            texto += "8";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btn9)
        {

            texto += "9";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btnC)
        {

            texto += "0";
            Pantalla.setText(texto);

        }else if(view.getId() == R.id.btnCOMA)
        {

            texto += ".";
            Pantalla.setText(""+texto);

        }else if(view.getId() == R.id.btnDIVISION)
        {

            texto += "/";
            Pantalla.setText(""+texto);

        }else if(view.getId() == R.id.btnX)
        {

            texto += "*";
            Pantalla.setText(""+texto);

        }else if(view.getId() == R.id.btnPORCENTAJE)
        {

            texto += "%";
            Pantalla.setText(""+texto);

        }else if(view.getId() == R.id.btnMAS)
        {

            texto += "+";
            Pantalla.setText(""+texto);

        }else if(view.getId() == R.id.btnMENOS)
        {

            texto += "-";
            Pantalla.setText(""+texto);

        }


      //  Pantalla.setText(""+texto);









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