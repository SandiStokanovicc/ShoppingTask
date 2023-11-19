import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Shopper } from '../models/Shopper.model';
import { BehaviorSubject } from 'rxjs';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class ShoppersService {
  public Shoppers = new BehaviorSubject<Shopper[]>([]);

  constructor(private http: HttpClient, private snackBar: MatSnackBar) { }

  getAllShoppers(){
    this.http.get<Shopper[]>('https://localhost:7229/api/Shopper').subscribe(result=>{
      this.Shoppers.next(result)
    },
     err => {
      this.snackBar.open(err.message, 'Close', {duration: 3000})
    })
  }
}
