import { Directive, ElementRef, HostBinding, HostListener, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appDirectiva]'
})
export class DirectivaDirective {

  @HostBinding('class.clase_prueba')
  private ishovering: boolean = false;


  constructor(private elemento :ElementRef, private renderer: Renderer2) 
  { 
  }



  @HostListener('mouseover') onMouseOver() {
    let part = this.elemento.nativeElement.querySelector('.card-text');
    this.renderer.setStyle(part, 'display', 'block');
    this.ishovering = true;
    }


    @HostListener('mouseout') onMouseOut() {
    let part = this.elemento.nativeElement.querySelector('.card-text');
    this.renderer.setStyle(part, 'display', 'none');
    this.ishovering = false;
  }




}


