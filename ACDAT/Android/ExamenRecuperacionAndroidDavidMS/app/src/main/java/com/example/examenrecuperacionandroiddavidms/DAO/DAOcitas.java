package com.example.examenrecuperacionandroiddavidms.DAO;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;

import com.example.examenrecuperacionandroiddavidms.POJOS.Citas;
import com.example.examenrecuperacionandroiddavidms.POJOS.Valoracion;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;

public class DAOcitas {

    public static Map<Citas, Citas> citas(Context context) {


        DatabaseHelper databaseHelper = DatabaseHelper.getInstance(context);

        Map<Citas, Citas> mapaCitas = new LinkedHashMap<>();
        SQLiteDatabase db = databaseHelper.getReadableDatabase();
        Cursor cursor = db.rawQuery("SELECT * FROM citas", null);

        if (cursor.moveToFirst()) {
            int citaIndex = cursor.getColumnIndex("cita");
            //int ingredientesIndex = cursor.getColumnIndex("ingredientes");

            do {
                if (citaIndex != -1 ) {
                    String cita = cursor.getString(citaIndex);
                    String autor = cursor.getString(citaIndex);
                    int nVeces = cursor.getInt(citaIndex);
                    String valoracion = cursor.getString(citaIndex);

                    Citas citas = new Citas(cita,autor,nVeces, Valoracion.valueOf(valoracion));
                    mapaCitas.put(citas, citas);
                }
            } while (cursor.moveToNext());
        }


        cursor.close();
        db.close();
        return mapaCitas;
    }

    public static void insertarCita(Context context, String cita, String autor, int nVeces, String valoracion) {
        DatabaseHelper databaseHelper = DatabaseHelper.getInstance(context);

        try (SQLiteDatabase db = databaseHelper.getWritableDatabase()) {
            ContentValues valores = new ContentValues();
            valores.put("cita", cita);
            valores.put("autor", autor);
            valores.put("nVeces", nVeces);
            valores.put("valoracion", valoracion);

            long resultado = db.insert("citas", null, valores);

            if (resultado != -1) {
                Log.i("Database", "Cita agregada correctamente a la base de datos.");
            } else {
                // Manejar el error de inserción
                Log.e("Database", "Error al agregar cita a la base de datos.");
            }
        } catch (Exception e) {
            // Manejar la excepción
            Log.e("Database", "Error al abrir o cerrar la base de datos: " + e.getMessage());
        }
    }

    public void eliminarCita(Context context, String nombreCita) {
        DatabaseHelper databaseHelper = DatabaseHelper.getInstance(context);

        try (SQLiteDatabase db = databaseHelper.getWritableDatabase()) {
            String whereClause = "cita" + " = ?";
            String[] whereArgs = {nombreCita};

            int filasAfectadas = db.delete("citas", whereClause, whereArgs);

            if (filasAfectadas > 0) {
                Log.i("Database", "cita eliminada correctamente de la base de datos.");
            } else {
                // Manejar el caso en que no se encuentre la pizza con el nombre proporcionado
                Log.w("Database", "No se encontró una cita con el nombre proporcionado.");
            }
        } catch (Exception e) {
            // Manejar la excepción
            Log.e("Database", "Error al abrir o cerrar la base de datos: " + e.getMessage());
        }
    }

    public void eliminarTodo(Context context)
    {
        DatabaseHelper databaseHelper = DatabaseHelper.getInstance(context);

        try (SQLiteDatabase db = databaseHelper.getWritableDatabase()) {
            String whereClause = "";
            String[] whereArgs = {};

            int filasAfectadas = db.delete("citas", whereClause, whereArgs);



            if (filasAfectadas > 0) {
                Log.i("Database", "cita eliminada correctamente de la base de datos.");
            } else {
                // Manejar el caso en que no se encuentre la pizza con el nombre proporcionado
                Log.w("Database", "No se encontró una cita con el nombre proporcionado.");
            }
        } catch (Exception e) {
            // Manejar la excepción
            Log.e("Database", "Error al abrir o cerrar la base de datos: " + e.getMessage());
        }


    }

}
