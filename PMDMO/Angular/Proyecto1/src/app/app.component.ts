import { Component } from '@angular/core';

@Component({
  selector: 'app-root',     //Nombre del componente
  templateUrl: './app.component.html', //Ruta relativa de donde estara el aspecto visual del componente
  styleUrls: ['./app.component.css'] //Ruta relativa de donde estaran los estilos 
})
export class AppComponent {
  title:String = 'Proyecto1';
}

