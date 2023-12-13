import { Directive, HostListener } from '@angular/core';

@Directive({
  selector: '[appDirectiva]'
})
export class DirectivaDirective {

  constructor(private texto : string) 
  {   }
  @HostListener('mouseover')
  
  this.texto.nativeElement.color = "red";

}
