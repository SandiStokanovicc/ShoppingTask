namespace TactaShoppingTask.DAL.DTOs.ItemDtos
{
    public class GetItemDto
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; } = 3;
    }
}
