package com.example.conexion_bd_sqlite;

import android.content.Context;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

public class DatabaseUtil {

    public static void copyDatabase(Context context, String assetFileName, String outputPath) throws IOException {
        InputStream inputStream = context.getAssets().open("example.db");
        OutputStream outputStream = new FileOutputStream(outputPath);

        byte[] buffer = new byte[1024];
        int length;
        while ((length = inputStream.read(buffer)) > 0) {
            outputStream.write(buffer, 0, length);
        }

        outputStream.flush();
        outputStream.close();
        inputStream.close();
    }
}
