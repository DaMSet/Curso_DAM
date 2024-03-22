import { Component } from '@angular/core';
import { Juego } from '../juego';
import { ServicioService } from '../servicio.service';

@Component({
  selector: 'app-cajon',
  templateUrl: './cajon.component.html',
  styleUrls: ['./cajon.component.css']
})

export class CajonComponent {

  servicio:ServicioService = new ServicioService;

  juegos :Juego[] = this.servicio.getjuegos();

  

}
