import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'GamesList',
    templateUrl: '../views/GamesList.component.html'
})
export class GamesListComponent {
    name: string ="Games List page";
}