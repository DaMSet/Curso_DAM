package com.example.pizzeria_david;

import java.util.List;

public class Pizza {
   private static int id_;
   private int id;
   private TamañoP Tamaño;
   private TipoMasa Masa;
   private List<String> listaDeIngredientes;
   private int Precio;
   private boolean Disponibilidad;

   public Pizza(int id, TamañoP tamaño, TipoMasa masa, List<String> listaDeIngredientes,int precio, boolean disponibilidad) {
      this.id = id_+1;
      this.Tamaño = tamaño;
      this.Masa = masa;
      this.listaDeIngredientes = listaDeIngredientes;
      this.Precio = precio;
      this.Disponibilidad = disponibilidad;
   }

   public TamañoP getTamaño() {
      return Tamaño;
   }

   public void setTamaño(TamañoP tamaño) {
      Tamaño = tamaño;
   }

   public int getId() {
      return id;
   }

   public void setId(int id) {
      this.id = id;
   }

   public boolean getDisponibilidad() {
      return Disponibilidad;
   }

   public void setDisponibilidad(boolean disponibilidad) {
      Disponibilidad = disponibilidad;
   }

   public int getPrecio() {
      return Precio;
   }

   public void setPrecio(int precio) {
      Precio = precio;
   }

   public List<String> getListaDeIngredientes() {
      return listaDeIngredientes;
   }

   public void setListaDeIngredientes(List<String> listaDeIngredientes) {
      this.listaDeIngredientes = listaDeIngredientes;
   }

   public TipoMasa getMasa() {
      return Masa;
   }

   public void setMasa(TipoMasa masa) {
      this.Masa = masa;
   }

   public void añadirIngredientes(String ingrediente){

      this.listaDeIngredientes.add(ingrediente);

   };


}
