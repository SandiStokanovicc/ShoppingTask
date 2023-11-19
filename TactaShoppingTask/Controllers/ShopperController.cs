using Microsoft.AspNetCore.Mvc;
using TactaShoppingTask.BLL.Interfaces;

namespace TactaShoppingTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopperController : ControllerBase
    {
        private readonly IShopperService shopperService;

        public ShopperController(IShopperService shopperService)
        {
            this.shopperService = shopperService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShoppers()
        {
            try
            {
                return Ok(await shopperService.GetAllShoppers());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }  
        }
    }
}
