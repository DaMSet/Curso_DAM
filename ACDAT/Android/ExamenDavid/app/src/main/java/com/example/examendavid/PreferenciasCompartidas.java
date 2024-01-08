package com.example.examendavid;

import android.content.Context;
import android.content.SharedPreferences;

public class PreferenciasCompartidas {

    private static PreferenciasCompartidas instancia;
    private SharedPreferences sharedPreferences;
    private static final String NOMBRE_PREFERENCIAS = "CredencialesUsuario";

    // Constructor privado para evitar instanciación directa
    private PreferenciasCompartidas(Context context) {
        sharedPreferences = context.getSharedPreferences(NOMBRE_PREFERENCIAS, Context.MODE_PRIVATE);
    }

    public static PreferenciasCompartidas obtenerInstancia(Context context) {
        if (instancia == null) {
            instancia = new PreferenciasCompartidas(context.getApplicationContext());
        }
        return instancia;
    }

    // Métodos para guardar y obtener datos de SharedPreferences
    public void guardarDatoString(String clave, String valor) {
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putString(clave, valor);
        editor.apply();
    }



    public String obtenerDato(String clave, String valorPorDefecto) {
        return sharedPreferences.getString(clave, valorPorDefecto);
    }

    public void guardarDatoBoolean(String clave, boolean valor) {
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putBoolean(clave, valor);
        editor.apply();
    }

    public boolean obtenerDatoBoolean(String clave, boolean valorPorDefecto) {
        return sharedPreferences.getBoolean(clave, valorPorDefecto);
    }


    //Para poder usarlo sera con esto
        /*
            // Obtener la instancia del Singleton SharedPreferencesManager
            PreferenciasCompartidas sharedPreferencesManager = PreferenciasCompartidas.obtenerInstancia(this);

            // Guardar un dato en PreferenciasCompartidas
            sharedPreferencesManager.guardarDatoString("clave", "valor");

            // Obtener un dato de PreferenciasCompartidas
            String valor = sharedPreferencesManager.obtenerDatoString("clave", "valor_por_defecto");
        */

}
