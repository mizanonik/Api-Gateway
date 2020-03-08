using Microsoft.AspNetCore.Mvc;

namespace ProductWebApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet(template:"GetProducts")]
        public string Get(){
            return "Product Service";
        }        
    }
}