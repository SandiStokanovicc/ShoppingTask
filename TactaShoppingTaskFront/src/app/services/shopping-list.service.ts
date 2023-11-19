import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Shopper } from '../models/Shopper.model';
import { BehaviorSubject, Subject } from 'rxjs';
import { ItemsService } from './items.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class ShoppingListService {

  public currentShopper = new BehaviorSubject<Shopper>(new Shopper(0, '', []));

  constructor(private http: HttpClient, private itemsService: ItemsService, private snackBar: MatSnackBar) { }

  getShoppingList(id: number){

    this.http.get<Shopper>('https://localhost:7229/api/ShoppingList?ShopperId=' + id).subscribe(result=>{
      this.currentShopper.next(result)
    },
    err => {
      this.snackBar.open('Error getting shopping list!', 'Close', {duration: 3000})
    }
    )
  }

  removeItemFromList(ItemId: number, ShopperId: number){
    this.http.delete<Shopper>('https://localhost:7229/api/ShoppingList?itemId='+ ItemId +'&shopperId=' + ShopperId).subscribe(result=>{
      this.currentShopper.next(result)
      this.itemsService.GetAllItems();
      this.snackBar.open('Item Removed Succesfully!', 'Close', {duration:3000})
    },
    err => {
      this.snackBar.open(err.message, 'Close', {duration: 3000})
    })
  }

  addItemToList(ItemId: number, ShopperId: number){
    this.http.post<Shopper>('https://localhost:7229/api/ShoppingList', {itemId: ItemId, shopperId: ShopperId}).subscribe(result=>{
      this.currentShopper.next(result);
      this.itemsService.GetAllItems();
      this.snackBar.open('Item Added Succesfully!', 'Close', {duration:3000})
    },
    err => {
      this.snackBar.open('Item Already Added!', 'Close', {duration: 3000, panelClass: ['red-snackbar']})
    })
  }
}
