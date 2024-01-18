package com.example.examenrecuperacionandroiddavidms.POJOS;

public class Citas {

    private int Codigo;
    private String Cita;
    private String Autor;
    private int NVeces;
    private Valoracion Valoracion;

    public Citas(String cita, String autor, int NVeces, Valoracion valoracion) {

        Cita = cita;
        Autor = autor;
        this.NVeces = NVeces;
        Valoracion = valoracion;
    }

    public void NvecesMas()
    {
        this.NVeces +=1;
    }
    public int getCodigo() {
        return Codigo;
    }

    public void setCodigo(int codigo) {
        Codigo = codigo;
    }

    public String getCita() {
        return Cita;
    }

    public void setCita(String cita) {
        Cita = cita;
    }

    public String getAutor() {
        return Autor;
    }

    public void setAutor(String autor) {
        Autor = autor;
    }

    public int getNVeces() {
        return NVeces;
    }

    public void setNVeces(int NVeces) {
        this.NVeces = NVeces;
    }

    public Valoracion getValoracion() {
        return Valoracion;
    }

    public void setValoracion(Valoracion valoracion) {
        Valoracion = valoracion;
    }
}
