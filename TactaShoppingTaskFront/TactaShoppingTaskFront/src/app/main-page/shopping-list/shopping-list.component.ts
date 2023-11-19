import { Component } from '@angular/core';
import { Shopper } from 'src/app/models/Shopper.model';
import { ShoppingListService } from 'src/app/services/shopping-list.service';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent {
  public currentShopper!: Shopper

  constructor(private shoppingListService: ShoppingListService){
  }

  ngOnInit(): void {
    this.shoppingListService.currentShopper.subscribe(result =>{
      this.currentShopper = result
    }
      )
  }

  removeItem(itemId: number){
    var shopperId = this.currentShopper.shopperId
    this.shoppingListService.removeItemFromList(itemId, shopperId);
  }
}
