package com.example.conexion_bd_sqlite;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

public class DatabaseManager {

    private static DatabaseManager instance;
    private DataBaseHelper dbHelper;
    private SQLiteDatabase database;

    private DatabaseManager(Context context, String databasePath) {
        dbHelper = new DataBaseHelper(context, databasePath);
    }

    public static synchronized DatabaseManager getInstance(Context context, String databasePath) {
        if (instance == null) {
            instance = new DatabaseManager(context, databasePath);
        }
        return instance;
    }

    public synchronized void open() {
        if (database == null || !database.isOpen()) {
            database = dbHelper.getWritableDatabase();
        }
    }

    public synchronized void close() {
        if (database != null && database.isOpen()) {
            dbHelper.close();
        }
    }

    public SQLiteDatabase getDatabase() {
        return database;
    }


}
