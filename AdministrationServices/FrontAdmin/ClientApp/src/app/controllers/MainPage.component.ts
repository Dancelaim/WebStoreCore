﻿import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'MainPage',
    templateUrl: '../views/MainPage.component.html'
})
export class MainPageComponent {
    name:string="Main page";
}