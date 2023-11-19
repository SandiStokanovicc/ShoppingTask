import { Item } from "./Item.Model";


export class Shopper {
  public shopperId: number;
  public shopperName: string;
  public items: Item[]

  constructor(ShopperId: number, ShopperName: string, ShoppingList: Item[]) {
    this.shopperId = ShopperId;
    this.shopperName = ShopperName;
    this.items = ShoppingList;
  }
}
