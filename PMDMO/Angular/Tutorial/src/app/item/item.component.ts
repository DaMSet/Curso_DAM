import { outputAst } from '@angular/compiler';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})

export class ItemComponent {

    @Input('item')  datos!: Joke;

    @Output() jokeDeleted = new EventEmitter<Joke>();


    borrarBroma()
    {
        this.jokeDeleted.emit(this.datos);
    
    }
}
 

