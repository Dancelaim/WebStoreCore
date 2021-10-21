import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { productsRequest } from '../models/Request/productsRequest';
import { ProductsResponse } from '../models/Response/ProductsResponse';


@Injectable()
export class ProductsService {
    private url = "31.40.29.21:44335";

    constructor(private http: HttpClient) {
    }

    getProducts(productsRequest: productsRequest) {
        let response: ProductsResponse = this.http.post(this.url + '/admin​/Product​/getProducts', productsRequest);
        return response.Products;
    }
}