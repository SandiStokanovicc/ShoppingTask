import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Item } from '../models/Item.Model';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {
  public Items = new BehaviorSubject<Item[]>([]);

  constructor(private http: HttpClient, private snackBar: MatSnackBar) { }

  GetAllItems(){
    this.http.get<Item[]>('https://localhost:7229/api/Item').subscribe(result=>{
      this.Items.next(result)
    },
    err => {
      this.snackBar.open(err, 'Close', {duration: 3000})
    }
    )
  }
}
