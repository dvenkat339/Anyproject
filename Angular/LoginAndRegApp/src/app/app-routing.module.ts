import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { from } from 'rxjs';
import {HomeComponent} from './home/home.component';
import {VenueComponent} from './venue/venue.component';
import {StadiumsComponent} from './stadiums/stadiums.component';
import { pathToFileURL } from 'url';

const routes: Routes = [
{path: "", pathMatch: "full", redirectTo: "/home"},
{path: "home", component: HomeComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
