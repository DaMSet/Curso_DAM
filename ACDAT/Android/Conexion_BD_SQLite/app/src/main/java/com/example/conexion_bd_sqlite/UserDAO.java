package com.example.conexion_bd_sqlite;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class UserDAO {

    private SQLiteDatabase database;

    public UserDAO(Context context) {
        database = DatabaseManager.getInstance(context, context.getExternalFilesDir(null) + "/example.db").getDatabase();
    }

    public long insertUser(String name, int age) {
        ContentValues values = new ContentValues();
        values.put("name", name);
        values.put("age", age);
        return database.insert("users", null, values);
    }

    public Cursor getAllUsers() {
        return database.query("users", null, null, null, null, null, null);
    }

    public int updateUser(long id, String name, int age) {
        ContentValues values = new ContentValues();
        values.put("name", name);
        values.put("age", age);
        return database.update("users", values, "id = ?", new String[]{String.valueOf(id)});
    }

    public void deleteUser(long id) {
        database.delete("users", "id = ?", new String[]{String.valueOf(id)});
    }
}
