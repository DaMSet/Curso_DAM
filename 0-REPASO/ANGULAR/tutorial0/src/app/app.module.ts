import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AlmacenComponent } from './almacen/almacen.component';
import { CajonComponent } from './cajon/cajon.component';

@NgModule({
  declarations: [
    AppComponent,
    AlmacenComponent,
    CajonComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
