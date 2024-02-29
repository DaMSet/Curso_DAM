package com.example.proyectojuego.grafico;

import android.graphics.Canvas;
import android.graphics.Rect;

public class Sprite {


    private final SpriteSheet spriteSheet;
    private final Rect rect;

    public Sprite(SpriteSheet spriteSheet, Rect rect) {

        this.spriteSheet = spriteSheet;
        this.rect = rect;
    }

    public void draw(Canvas canvas,int x, int y){
        Rect destRect = new Rect(x, y, x + rect.width(), y + rect.height());

        canvas.drawBitmap(
                spriteSheet.getBitmap(),
                rect,
                destRect,
                null
        );

    }




}
