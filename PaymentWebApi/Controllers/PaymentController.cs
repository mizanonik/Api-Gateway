using Microsoft.AspNetCore.Mvc;

namespace PaymentWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        [HttpGet(template:"GetPayments")]
        public string get(){
            return "Payment service";
        }
    }
}