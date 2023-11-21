package com.example.pizzeria_david;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;


import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class MyAdaptador extends RecyclerView.Adapter<MyAdaptador.MyViewHolder> {

    private List<String> dataList;

    // Constructor que recibe la lista de datos
    public MyAdaptador(List<String> dataList) {
        this.dataList = dataList;
    }

    // Crea y devuelve una nueva instancia de MyViewHolder
    @Override
    public MyViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        // Infla el diseño del elemento de la lista
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_layout, parent, false);
        // Crea una nueva instancia de MyViewHolder

        return new MyViewHolder(view);
        //return null;
    }

    // Llena la vista con datos específicos en una posición dada
    @Override
    public void onBindViewHolder(MyViewHolder holder, int position) {
        // Obtiene el dato en la posición especificada
        String data = dataList.get(position);
        // Establece el dato en el TextView de la vista
        holder.textViewItem.setText(data);
    }

    // Devuelve la cantidad total de elementos en la lista de datos
    @Override
    public int getItemCount() {
        return dataList.size();
    }

    // Clase interna que representa cada elemento de la lista
    public static class MyViewHolder extends RecyclerView.ViewHolder {
        // Vista que representa un elemento individual en la lista
        TextView textViewItem;

        // Constructor que recibe la vista
        public MyViewHolder(View itemView) {
            super(itemView);
            // Inicializa la vista del TextView
            textViewItem = itemView.findViewById(R.id.textViewItem);
        }
    }


}
// mirar

//https://www.youtube.com/watch?v=k3zoVAMuW5w