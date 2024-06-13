package com.example.conexion_bd_sqlite;
/*
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
}*/


/*
import android.content.Context;
import android.database.Cursor;
import android.os.Bundle;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import java.io.File;
import java.io.IOException;

public class MainActivity extends AppCompatActivity {

    private UserDAO userDAO;
    private ProductDAO productDAO;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Ruta de la base de datos en el almacenamiento interno
        File databaseFile = new File(getFilesDir(), "example.db");
        String databasePath = databaseFile.getAbsolutePath();

        // Copiar la base de datos si no existe
        if (!databaseFile.exists()) {
            try {
                DatabaseUtil.copyDatabase(this, "example.db", databasePath);
                Toast.makeText(this, "Database copied to internal storage", Toast.LENGTH_SHORT).show();
            } catch (IOException e) {
                e.printStackTrace();
                Toast.makeText(this, "Error copying database", Toast.LENGTH_SHORT).show();
                return;
            }
        }

        // Inicializar la base de datos
        initializeDatabase(databasePath);
    }

    private void initializeDatabase(String databasePath) {
        // Abrir la base de datos
        DatabaseManager.getInstance(this, databasePath).open();

        // Inicializar DAOs
        userDAO = new UserDAO(this);
        productDAO = new ProductDAO(this);

        // Realizar operaciones en la base de datos
        performDatabaseOperations();

        // Cerrar la base de datos
        DatabaseManager.getInstance(this, databasePath).close();
    }

    private void performDatabaseOperations() {
        // Insertar un usuario
        long userId = userDAO.insertUser("John Doe", 30);
        Toast.makeText(this, "User inserted with ID: " + userId, Toast.LENGTH_SHORT).show();

        // Actualizar el usuario
        userDAO.updateUser(userId, "John Smith", 31);
        Toast.makeText(this, "User updated with ID: " + userId, Toast.LENGTH_SHORT).show();

        // Obtener todos los usuarios
        Cursor userCursor = userDAO.getAllUsers();
        if (userCursor.moveToFirst()) {
            do {
                int id = userCursor.getInt(userCursor.getColumnIndexOrThrow("id"));
                String name = userCursor.getString(userCursor.getColumnIndexOrThrow("name"));
                int age = userCursor.getInt(userCursor.getColumnIndexOrThrow("age"));
                Toast.makeText(this, "User: " + id + ", " + name + ", " + age, Toast.LENGTH_SHORT).show();
            } while (userCursor.moveToNext());
        }
        userCursor.close();

        // Eliminar el usuario
        userDAO.deleteUser(userId);
        Toast.makeText(this, "User deleted with ID: " + userId, Toast.LENGTH_SHORT).show();

        // Insertar un producto
        long productId = productDAO.insertProduct("Laptop", 999.99);
        Toast.makeText(this, "Product inserted with ID: " + productId, Toast.LENGTH_SHORT).show();

        // Actualizar el producto
        productDAO.updateProduct(productId, "Gaming Laptop", 1299.99);
        Toast.makeText(this, "Product updated with ID: " + productId, Toast.LENGTH_SHORT).show();

        // Obtener todos los productos
        Cursor productCursor = productDAO.getAllProducts();
        if (productCursor.moveToFirst()) {
            do {
                int id = productCursor.getInt(productCursor.getColumnIndexOrThrow("id"));
                String name = productCursor.getString(productCursor.getColumnIndexOrThrow("name"));
                double price = productCursor.getDouble(productCursor.getColumnIndexOrThrow("price"));
                Toast.makeText(this, "Product: " + id + ", " + name + ", " + price, Toast.LENGTH_SHORT).show();
            } while (productCursor.moveToNext());
        }
        productCursor.close();

        // Eliminar el producto
        productDAO.deleteProduct(productId);
        Toast.makeText(this, "Product deleted with ID: " + productId, Toast.LENGTH_SHORT).show();
    }
}
*/


import android.content.Context;
        import android.content.res.AssetManager;
        import android.database.Cursor;
        import android.os.Bundle;
        import android.widget.Toast;
        import androidx.appcompat.app.AppCompatActivity;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

public class MainActivity extends AppCompatActivity {

    private UserDAO userDAO;
    private ProductDAO productDAO;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Ruta de la base de datos en el almacenamiento interno
        String databasePath = getDatabasePath("example.db").getAbsolutePath();



        // Inicializar la base de datos y copiar desde assets si es necesario
        initializeDatabase(databasePath);

        // Realizar operaciones de prueba
        performTestOperations();
    }

    private void initializeDatabase(String databasePath) {
        // Verificar si la base de datos ya existe en el almacenamiento interno
        File dbFile = new File(databasePath);
        if (!dbFile.exists()) {
            // Si no existe, copiar desde assets
            copyDatabaseFromAssets(this, "example.db", databasePath);
        }

        // Abrir la base de datos
        DatabaseManager.getInstance(this, databasePath).open();

        // Inicializar DAOs
        userDAO = new UserDAO(this);
        productDAO = new ProductDAO(this);
    }

    private void copyDatabaseFromAssets(Context context, String dbName, String destinationPath) {
        AssetManager assetManager = context.getAssets();
        InputStream inputStream = null;
        OutputStream outputStream = null;

        try {
            inputStream = assetManager.open(dbName);
            outputStream = new FileOutputStream(destinationPath);

            byte[] buffer = new byte[1024];
            int length;
            while ((length = inputStream.read(buffer)) > 0) {
                outputStream.write(buffer, 0, length);
            }

            Toast.makeText(context, "Database copied from assets", Toast.LENGTH_SHORT).show();

        } catch (IOException e) {
            e.printStackTrace();
            Toast.makeText(context, "Failed to copy database from assets", Toast.LENGTH_SHORT).show();

        } finally {
            try {
                if (inputStream != null) inputStream.close();
                if (outputStream != null) outputStream.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }



    private void performTestOperations() {
        // Insertar usuario
        long userId1 = userDAO.insertUser("david", 28);
        long userId2 = userDAO.insertUser("jose", 30);
        Toast.makeText(this, "Users inserted with IDs: " + userId1 + ", " + userId2, Toast.LENGTH_SHORT).show();

        // Insertar producto
        long productId1 = productDAO.insertProduct("minas", 999.99);
        long productId2 = productDAO.insertProduct("tele", 599.99);
        Toast.makeText(this, "Products inserted with IDs: " + productId1 + ", " + productId2, Toast.LENGTH_SHORT).show();

        // Modificar usuario
        userDAO.updateUser(userId1, "Alice Smith", 29);
        Toast.makeText(this, "User updated with ID: " + userId1, Toast.LENGTH_SHORT).show();

        // Modificar producto
        productDAO.updateProduct(productId1, "Gaming Laptop", 1299.99);
        Toast.makeText(this, "Product updated with ID: " + productId1, Toast.LENGTH_SHORT).show();

        // Eliminar usuario
        userDAO.deleteUser(userId2);
        Toast.makeText(this, "User deleted with ID: " + userId2, Toast.LENGTH_SHORT).show();

        // Eliminar producto
        productDAO.deleteProduct(productId2);
        Toast.makeText(this, "Product deleted with ID: " + productId2, Toast.LENGTH_SHORT).show();

    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        // Cerrar la base de datos al destruir la actividad

        DatabaseManager.getInstance(this, getDatabasePath("example.db").getAbsolutePath()).close();
    }
}

