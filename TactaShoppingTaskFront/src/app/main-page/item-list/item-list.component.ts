import { Component } from '@angular/core';
import { Item } from 'src/app/models/Item.Model';
import { Shopper } from 'src/app/models/Shopper.model';
import { ItemsService } from 'src/app/services/items.service';
import { ShoppingListService } from 'src/app/services/shopping-list.service';

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.css']
})
export class ItemListComponent {
  public currentShopper!: Shopper
  public itemList: Item[] = []

  constructor(private itemService: ItemsService, private shoppingListService: ShoppingListService){}

  ngOnInit(): void {
    this.itemService.GetAllItems();
    this.itemService.Items.subscribe(result=> {
      this.itemList = result
    })
    this.shoppingListService.currentShopper.subscribe(result =>{
      this.currentShopper = result;
    })
  }

  addItemToList(itemId: number){
    var shopperId = this.currentShopper.shopperId;

    this.shoppingListService.addItemToList(itemId, shopperId);
  }

}
