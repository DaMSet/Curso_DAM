import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
//import { AppComponent } from './app.component';
import { JokesComponent } from './jokes/jokes.component';

@NgModule({
  declarations: [
    //AppComponent,
    JokesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [JokesComponent]
})

export class AppModule {
  



}
