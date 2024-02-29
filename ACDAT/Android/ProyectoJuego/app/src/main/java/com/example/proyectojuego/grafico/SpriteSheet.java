package com.example.proyectojuego.grafico;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Rect;

import com.example.proyectojuego.R;

public class SpriteSheet {

    private Bitmap bitmap;

    public SpriteSheet(Context context){

        BitmapFactory.Options bitmapOptions = new BitmapFactory.Options();

        bitmapOptions.inScaled = false;

        bitmap = BitmapFactory.decodeResource(context.getResources(), R.drawable.sprite_sheet,bitmapOptions);

    }

    public Sprite[] getArrayJugadorSprite(){


        Sprite[] listaSprite = new Sprite[9];
        listaSprite[0]= new Sprite(this,new Rect(0*63,0,1*63,1*63));
        listaSprite[1]= new Sprite(this,new Rect(1*63,0,2*63,1*63));
        listaSprite[2]= new Sprite(this,new Rect(2*63,0,3*63,1*63));

        listaSprite[3]= new Sprite(this,new Rect(0*100,1*63,1*63,2*63));
        listaSprite[4]= new Sprite(this,new Rect(1*100,1*63,2*63,2*63));
        listaSprite[5]= new Sprite(this,new Rect(2*100,1*63,3*63,2*63));

        listaSprite[6]= new Sprite(this,new Rect(0*200,2*63,1*63,3*63));
        listaSprite[7]= new Sprite(this,new Rect(1*200,2*63,2*63,3*63));
        listaSprite[8]= new Sprite(this,new Rect(2*200,2*63,3*63,3*63));

        return listaSprite;

    }

    public Bitmap getBitmap() {
    return bitmap;
    }
}
