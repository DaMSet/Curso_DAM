package com.example.a2trimestre_inicio;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

public class PruebaCicloDeVida extends Activity {

    StringBuilder builder = new StringBuilder();
    TextView textView;

    private void log(String text)
    {
        Log.d("Prueba ciclo de vida",text);
        builder.append(text);
        builder.append('\n');
        textView.setText(builder.toString());
    }


    //public void onCreate(Bundle );



}
