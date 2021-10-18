import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from '../models/Request/product';

@Injectable()
export class Products {
    private url = "";

    constructor(private http: HttpClient) {
    }

    getProducts() {
       
    }
}