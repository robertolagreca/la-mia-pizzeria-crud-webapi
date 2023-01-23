using LaMiaPizzeriaCategoriaETagELogin.Database;
using LaMiaPizzeriaCategoriaETagELogin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LaMiaPizzeriaCategoriaETagELogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzawebapiController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizzasWebApi = db.Pizzas.Include(pizza => pizza.Tags).ToList<Pizza>();

                return Ok(pizzasWebApi);
            }
        }

    }
}
