using Microsoft.AspNetCore.Mvc;

namespace AspNetCore
{
    [Route("[controller]")]
    public class OrderController : Controller
    {

        [HttpPost]
        public ActionResult Post([FromBody] Order value)
        {
            return Ok();
            //return Ok(new { total = 19.03 });
        }
    }

    [Route("[controller]")]
    public class FeedbackController : Controller
    {
        [HttpPost]
        public ActionResult Post()
        {
            return Ok();
        }
    }

    public class Order
    {
        public decimal[] Prices { get; set; }
        public int[] Quantities { get; set; }
        public string Country { get; set; }
        public string Reduction { get; set; }
    }
}