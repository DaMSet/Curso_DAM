import { Component, EventEmitter, Output } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'Joke-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})


export class FormComponent {

  @Output() CreadorDeBromas = new EventEmitter<Joke>();

  CrearBroma(broma :string, respuestaBroma :string)
  {

    this.CreadorDeBromas.emit(new Joke(broma,respuestaBroma));

  }

}
