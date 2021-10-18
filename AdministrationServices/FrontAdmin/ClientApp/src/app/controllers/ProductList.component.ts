import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'ProductList',
    templateUrl: '../views/ProductList.component.html'
})
export class ProductListComponent {
    name:string="Product List page";
}