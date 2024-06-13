package com.example.conexion_bd_sqlite;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class ProductDAO {

    private SQLiteDatabase database;

    public ProductDAO(Context context) {
        database = DatabaseManager.getInstance(context, context.getExternalFilesDir(null) + "/example.db").getDatabase();
    }

    public long insertProduct(String name, double price) {
        ContentValues values = new ContentValues();
        values.put("name", name);
        values.put("price", price);
        return database.insert("products", null, values);
    }

    public Cursor getAllProducts() {
        return database.query("products", null, null, null, null, null, null);
    }

    public int updateProduct(long id, String name, double price) {
        ContentValues values = new ContentValues();
        values.put("name", name);
        values.put("price", price);
        return database.update("products", values, "id = ?", new String[]{String.valueOf(id)});
    }

    public void deleteProduct(long id) {
        database.delete("products", "id = ?", new String[]{String.valueOf(id)});
    }
}

