package com.example.examenrecuperacionandroiddavidms.DAO;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DatabaseHelper extends SQLiteOpenHelper {

    private static final String NOMBRE_BASE_DE_DATOS = "BDCitas";
    private static final int VERSION_BASE_DE_DATOS = 1;
    private static DatabaseHelper databaseHelper = null;

    private DatabaseHelper(Context context) {
        super(context, NOMBRE_BASE_DE_DATOS, null, VERSION_BASE_DE_DATOS);
    }

    //CREAR LAS TABLAS
    @Override
    public void onCreate(SQLiteDatabase db) {
        String queryCrearTablacitas = "CREATE TABLE IF NOT EXISTS citas (" +
                "codigo INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                "cita TEXT NOT NULL, " +
                "autor TEXT, " +
                "nVeces INTEGER, " +
                "valoracion TEXT);";
        //

        db.execSQL(queryCrearTablacitas);

        insertarCitaDefault(db, "hay que pasarlo bien 1", "david", 1, "normal");
        insertarCitaDefault(db, "hay que pasarlo bien 2", "pepe", 1, "bien");
        insertarCitaDefault(db, "hay que pasarlo bien 3", "jojo", 4, "bien");
        insertarCitaDefault(db, "hay que pasarlo bien 4", "Pequeña", 9, "normal");
        insertarCitaDefault(db, "hay que pasarlo bien con quesos", "ale", 23, "mal");
/*
        String queryCrearTablaUsuario = "CREATE TABLE IF NOT EXISTS usuarios(" +
                "id_usuario INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                "nombre TEXT NOT NULL," +
                "contrasena TEXT NOT NULL);";
        db.execSQL(queryCrearTablaUsuario);

        insertarUsuarioDefault(db, "admin", "admin");*/
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {


    }


    //METODOS PARA INSERTAR AL CREAR LAS TABLAS
    private void insertarCitaDefault(SQLiteDatabase db,  String cita, String autor,int nVeces ,String valoracion) {
        ContentValues valores = new ContentValues();
        valores.put("cita", cita);
        valores.put("autor", autor);
        valores.put("nVeces", nVeces);
        valores.put("valoracion", valoracion);
        db.insert("citas", null, valores);
    }

    /*
    private void insertarUsuarioDefault(SQLiteDatabase db, String nombre, String contrasena) {
        ContentValues valores = new ContentValues();
        valores.put("nombre", nombre);
        valores.put("contrasena", contrasena);
        db.insert("usuarios", null, valores);
    }
*/

    //PATRON SINGLETON
    public static synchronized DatabaseHelper getInstance(Context context) {
        if (databaseHelper == null) {
            databaseHelper = new DatabaseHelper(context.getApplicationContext());
        }
        return databaseHelper;
    }




}
