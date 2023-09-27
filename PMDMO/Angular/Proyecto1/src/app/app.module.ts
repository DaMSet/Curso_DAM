import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HijoComponent } from './hijo/hijo.component';
import { Hijo2Component } from './hijo2/hijo2.component';
import { Hijo3Component } from './hijo3/hijo3.component';
import { Hijo4Component } from './hijo4/hijo4.component';

@NgModule({
  declarations: [
    AppComponent,
    HijoComponent,
    Hijo2Component,
    Hijo3Component,
    Hijo4Component
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
