using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TactaShoppingTask.BLL.Interfaces;
using TactaShoppingTask.DAL.DTOs.ShoppingListDtos;

namespace TactaShoppingTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            this.shoppingListService = shoppingListService;
        }

        [HttpPost]
        public async Task<IActionResult> AddToShoppingList(AddToListDto newList)
        {
            try
            {
                return Ok(await shoppingListService.AddToShoppingList(newList));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetShoppingList(int ShopperId)
        {
            try
            {
                return Ok(await shoppingListService.GetShoppingList(ShopperId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveItemFromShoppingList(int itemId, int shopperId)
        {
            try
            {
                return Ok(await shoppingListService.RemoveItemFromShoppingList(itemId, shopperId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
