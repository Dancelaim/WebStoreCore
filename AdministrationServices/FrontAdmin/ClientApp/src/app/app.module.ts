import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { ListProductComponent } from './ListProduct.component';
import { MainPageComponent } from './MainPage.component';
import { GamesListComponent } from './GamesList.component';

// определение маршрутов
const appRoutes: Routes = [
    { path: '', component: MainPageComponent },
    { path: 'product-list', component: ListProductComponent },
    { path: 'games-list', component: GamesListComponent },
    { path: '**', redirectTo: '/' }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, MainPageComponent, ListProductComponent, GamesListComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }