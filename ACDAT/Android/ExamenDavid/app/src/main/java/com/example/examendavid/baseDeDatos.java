package com.example.examendavid;

import java.util.List;

public class baseDeDatos {

    private List<String> listaPalabras;

    private static baseDeDatos instanciaLista = null;

    private baseDeDatos()
    {

       listaPalabras.add("belleza");
       listaPalabras.add("pasa");
       listaPalabras.add("lista");

        listaPalabras.add("salud");
        listaPalabras.add("agua");
        listaPalabras.add("comer");

        listaPalabras.add("pizza");
        listaPalabras.add("mano");
        listaPalabras.add("manzana");

        listaPalabras.add("palabra1");
        listaPalabras.add("palabra2");
        listaPalabras.add("palabra3");

        listaPalabras.add("palabra4");
        listaPalabras.add("palabra5");
        listaPalabras.add("palabra6");

        listaPalabras.add("palabra7");
        listaPalabras.add("palabra8");
        listaPalabras.add("palabra9");

        listaPalabras.add("palabra10");
        listaPalabras.add("palabra11");
        listaPalabras.add("palabra12");


    }

    public static baseDeDatos obtenerInstancia()
    {
        if (instanciaLista == null) {

            instanciaLista = new baseDeDatos();
        }
        return instanciaLista;
    }

    public void eliminarPalabra(String palabra1) {
        listaPalabras.removeIf(palabra -> palabra.equals(palabra1));
    }


}
