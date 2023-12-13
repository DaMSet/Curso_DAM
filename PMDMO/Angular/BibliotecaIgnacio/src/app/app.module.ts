import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FiltersPanelComponent } from './filters-panel/filters-panel.component';
import { BooksListComponent } from './books-list/books-list.component';
import { HeaderComponent } from './header/header/header.component';
import { Service } from 'src/service/service.service';
import { TuberiaPipe } from './tuberia.pipe';
import { ComponenteComponent } from './componente/componente.component';
import { DirectivaDirective } from './directiva.directive';
import { AppRouting2Module } from './app-routing2.module';

@NgModule({
  declarations: [
    AppComponent,
    FiltersPanelComponent,
    BooksListComponent,
    HeaderComponent,
    TuberiaPipe,
    ComponenteComponent,
    DirectivaDirective
  ],
  imports: [
    BrowserModule,
    AppRouting2Module
  ],
  providers: [Service],
  bootstrap: [AppComponent]
})
export class AppModule { }
