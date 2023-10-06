import { Component, Input } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})

export class ItemComponent {

    @Input('item')  datos!: Joke;

}
