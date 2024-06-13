package com.example.ejemploconexionsqlite;


import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;

public class daoContacto {

    SQLiteDatabase cx;

    ArrayList<Contacto> Lista;
    Contacto contacto;
    Context context;
    String nombreBaseDatos = "BDContactos";
    String tabla = "create table if not exists contacto(id integer primary key autoincrement,nombre text, telefono text, email text, edad integer)";


    public daoContacto(Context context){

        this.cx = context.openOrCreateDatabase(nombreBaseDatos,Context.MODE_WORLD_WRITEABLE,null);

        cx.execSQL(tabla);


    }


    public boolean insertar(Contacto contacto){


        return true;
    }


    public boolean eliminar(int id){


        return true;
    }

    public boolean editar(Contacto contacto){


        return true;
    }


    public ArrayList<Contacto> verTodos(){

        return Lista;
    }


    public Contacto verUno(int id){
        return contacto;
    }

}
