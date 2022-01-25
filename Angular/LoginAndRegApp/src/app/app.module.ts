import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { VenueComponent } from './venue/venue.component';
import { StadiumsComponent } from './stadiums/stadiums.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    VenueComponent,
    StadiumsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
