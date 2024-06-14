package com.example.libreria_consqlite;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class CustomAdapter extends RecyclerView.Adapter<CustomAdapter.MyViewHolder> {

    private Context context;

    Activity activity;
    private ArrayList<String> book_id,book_title, book_author, book_pages;



    CustomAdapter(Activity activity, Context context,ArrayList book_id,ArrayList book_title,ArrayList book_author,ArrayList book_pages){

        this.activity  = activity;
        this.context = context;
        this.book_id = book_id;
        this.book_title = book_title;
        this.book_author = book_author;
        this.book_pages = book_pages;

    }

    @NonNull
    @Override
    public MyViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(context);
        View view = inflater.inflate(R.layout.my_row,parent,false);

        return new MyViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull MyViewHolder holder,int position) {



        holder.book_id_txt.setText(String.valueOf(book_id.get(holder.getAdapterPosition())));
        holder.book_title_txt.setText(String.valueOf(book_title.get(holder.getAdapterPosition())));
        holder.book_author_txt.setText(String.valueOf(book_author.get(holder.getAdapterPosition())));
        holder.book_pages_txt.setText(String.valueOf(book_pages.get(holder.getAdapterPosition())));

        holder.mainLayout_De_my_row.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(context, UpdateActivity.class);
                intent.putExtra("id",String.valueOf(book_id.get(holder.getAdapterPosition())));
                intent.putExtra("title",String.valueOf(book_title.get(holder.getAdapterPosition())));
                intent.putExtra("author",String.valueOf(book_author.get(holder.getAdapterPosition())));
                intent.putExtra("pages",String.valueOf(book_pages.get(holder.getAdapterPosition())));
                activity.startActivityForResult(intent,1);

            }
        });

    }

    @Override
    public int getItemCount() {
        return book_id.size();
    }

    public class MyViewHolder extends RecyclerView.ViewHolder {

        TextView book_id_txt, book_title_txt,book_author_txt, book_pages_txt;

        LinearLayout mainLayout_De_my_row;

        public MyViewHolder(@NonNull View itemView) {
            super(itemView);
                    book_id_txt = itemView.findViewById(R.id.book_id_text);
                    book_title_txt = itemView.findViewById(R.id.book_title_text);
                    book_author_txt = itemView.findViewById(R.id.book_author_text);
                    book_pages_txt = itemView.findViewById(R.id.book_pages_text);
            mainLayout_De_my_row = itemView.findViewById(R.id.mainLayout_De_my_row);
        }
    }
}