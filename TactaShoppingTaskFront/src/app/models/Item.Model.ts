export class Item {
  public itemId: number;
  public itemName: string;
  public itemQuantity: number;

  constructor(ItemId: number, ItemName: string, ItemQuantity: number){
    this.itemId = ItemId;
    this.itemName = ItemName;
    this.itemQuantity = ItemQuantity
  }
}
