package com.example.pizzeria_david;

import android.content.Context;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class PizzaDAO {

    private List<Pizza> pizzas ;
    private static PizzaDAO instanciaPizzas = null;

    private PizzaDAO()
    {

        pizzas.add(new Pizza(TamañoP.NORMAL,TipoMasa.NORMAL, new ArrayList<String>(Arrays.asList("tomate1", "queso1", "queso parmesano1")),15, true));
        pizzas.add(new Pizza(TamañoP.FAMILIAR,TipoMasa.NORMAL, new ArrayList<String>(Arrays.asList("tomate2", "queso2", "queso parmesano2")),18, true));
        pizzas.add(new Pizza(TamañoP.MEDIANA,TipoMasa.FINA, new ArrayList<String>(Arrays.asList("tomate3", "queso3", "queso parmesano3")),19, true));
        pizzas.add(new Pizza(TamañoP.PEQUEÑA,TipoMasa.PESADA, new ArrayList<String>(Arrays.asList("tomate4", "queso4", "queso parmesano4")),10, true));
        pizzas.add(new Pizza(TamañoP.NORMAL,TipoMasa.EXTRAFINA, new ArrayList<String>(Arrays.asList("tomate5", "queso5", "queso parmesano5")),16, true));

    }

    public static PizzaDAO obtenerInstancia()
    {
        if (instanciaPizzas == null) {

            instanciaPizzas = new PizzaDAO();
        }
        return instanciaPizzas;
    }

    public List<Pizza> obtenerTodasLasPizzas() {
        return new ArrayList<>(pizzas);
    }


    public Pizza obtenerPizzaPorId(int id) {
        for (Pizza pizza : pizzas) {
            if (pizza.getId() == id) {
                return pizza;
            }
        }
        return null;
    }


    public void agregarPizza(Pizza pizza) {
        pizza.setId(Pizza.getId_()); // Usar el método estático para obtener un nuevo ID
        pizzas.add(pizza);
    }


    public void actualizarPizza(Pizza pizza) {
        for (int i = 0; i < pizzas.size(); i++) {
            if (pizzas.get(i).getId() == pizza.getId()) {
                pizzas.set(i, pizza);
                break;
            }
        }
    }


    public void eliminarPizza(int id) {
        pizzas.removeIf(pizza -> pizza.getId() == id);
    }

}


/*

PARA PODER UTILIZAR LAS CONSULTAS EN PHP DEBEREMOS AÑADIR VARIAS LINEAS DE CODIGO
EN
ANDROIDMANIFEST / debajo de manifest xml / <uses-permission android:name="android.permission.INTERNET"></uses-permission>

BUILDGRADLE / dentro de dependencies / implementation("com.android.volley:volley:1.1.0")

y sincronizamos con sync NOW


CREATE DATABASE pizzeria_db;

CREATE TABLE Pizza (
    id SERIAL PRIMARY KEY,
    nombre VARCHAR(20),
    tamaño VARCHAR(20),
    masa VARCHAR(20),
    precio INT,
    disponibilidad BOOLEAN
);

CREATE TABLE Ingrediente (
    id SERIAL PRIMARY KEY,
    nombre VARCHAR(50) UNIQUE
);

CREATE TABLE PizzaIngrediente (
    pizza_id INT REFERENCES Pizza(id),
    ingrediente_id INT REFERENCES Ingrediente(id),
    PRIMARY KEY (pizza_id, ingrediente_id)
);

///////////////

 -- Insertar tamaños y masas directamente en la tabla Pizza
INSERT INTO Pizza (nombre,tamaño, masa, precio, disponibilidad) VALUES
    ('PIZZA1','NORMAL', 'NORMAL', 10, true),
    ('PIZZA2','MEDIANA', 'FINA', 15, true),
    ('PIZZA3','FAMILIAR', 'EXTRAFINA', 20, false),
    ('PIZZA4','PEQUEÑA', 'FINA', 8, true),
    ('PIZZA5','NORMAL', 'PESADA', 12, true),
    ('PIZZA6','MEDIANA', 'NORMAL', 14, false),
    ('PIZZA7','FAMILIAR', 'EXTRAFINA', 18, true),
    ('PIZZA8','NORMAL', 'FINA', 10, true);

-- Insertar ingredientes en la tabla Ingrediente
INSERT INTO Ingrediente (nombre) VALUES
    ('Tomate'),
    ('Queso'),
    ('Jamón'),
    ('Champiñones'),
    ('Pepperoni'),
    ('Cebolla'),
    ('Pimiento'),
    ('Aceitunas');

-- Asociar ingredientes a pizzas específicas en la tabla PizzaIngrediente
INSERT INTO PizzaIngrediente (pizza_id, ingrediente_id) VALUES
    (1, 1),  -- Tomate en la primera pizza
    (1, 2),  -- Queso en la primera pizza
    (2, 2),  -- Queso en la segunda pizza
    (2, 3),  -- Jamón en la segunda pizza
    (3, 1),  -- Tomate en la tercera pizza
    (3, 2),  -- Queso en la tercera pizza
    (3, 4),  -- Champiñones en la tercera pizza
    (4, 2),  -- Queso en la cuarta pizza
    (4, 3),  -- Jamón en la cuarta pizza
    (4, 4),  -- Champiñones en la cuarta pizza
    (5, 1),  -- Tomate en la quinta pizza
    (5, 2),  -- Queso en la quinta pizza
    (5, 3),  -- Jamón en la quinta pizza
    (5, 4),  -- Champiñones en la quinta pizza
    (6, 1),  -- Tomate en la sexta pizza
    (6, 2),  -- Queso en la sexta pizza
    (6, 4),  -- Champiñones en la sexta pizza
    (7, 1),  -- Tomate en la séptima pizza
    (7, 3),  -- Jamón en la séptima pizza
    (7, 4),  -- Champiñones en la séptima pizza
    (8, 2),  -- Queso en la octava pizza
    (8, 4);  -- Champiñones en la octava pizza


* */