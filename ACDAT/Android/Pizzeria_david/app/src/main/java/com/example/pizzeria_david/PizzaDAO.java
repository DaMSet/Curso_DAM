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
