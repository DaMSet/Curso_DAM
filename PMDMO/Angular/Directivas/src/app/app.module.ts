import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DirectivaDirective } from './directiva.directive';
import { ClaseComponent } from './clase/clase.component';

@NgModule({
  declarations: [
    AppComponent,
    DirectivaDirective,
    ClaseComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
