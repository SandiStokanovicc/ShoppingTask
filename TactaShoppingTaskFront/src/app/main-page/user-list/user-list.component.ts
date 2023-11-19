import { Component } from '@angular/core';
import { Shopper } from 'src/app/models/Shopper.model';
import { ShoppersService } from 'src/app/services/shoppers.service';
import { ShoppingListService } from 'src/app/services/shopping-list.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent {

  shopperList: Shopper[] = []
  selectedShopper: number = 0

  constructor(private shoppersService: ShoppersService, private shoppingListService: ShoppingListService){}

  ngOnInit(): void {
    this.shoppersService.getAllShoppers();
    this.shoppersService.Shoppers.subscribe(result=> {
      this.shopperList = result
    })
  }

  selectShopper(id: number ){
    this.selectedShopper = id;
    this.shoppingListService.getShoppingList(id)
  }

}
