package com.example.examenrecuperacionandroiddavidms.SERVICIO;

import android.content.Context;


import com.example.examenrecuperacionandroiddavidms.DAO.DAOcitas;
import com.example.examenrecuperacionandroiddavidms.POJOS.Citas;

import java.util.Iterator;
import java.util.Map;

public class Servicio {

    private static Servicio servicio = null;
    private Map<Citas, Citas> citas;

    private Context context;
    private Servicio(Context context){
        this.context = context;
        citas = DAOcitas.citas(context);
    }

    public Map<Citas, Citas> getCitas(){
        return citas;
    }


    public void setContext(Context context){
        this.context = context;
    }


    public void anadirCita(String cita, String autor, int nVeces, String valoracion){
        DAOcitas.insertarCita(context, cita, autor,nVeces,valoracion);
    }



    public static Servicio getInstance(Context context){
        if(servicio == null){
            return servicio = new Servicio(context);
        }
        else{
            servicio.setContext(context);
            return servicio;
        }
    }



}
