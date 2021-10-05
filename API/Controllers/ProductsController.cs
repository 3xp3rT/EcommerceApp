using Microsoft.AspNetCore.Mvc;
using Infostructure.Data;
using Core.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private readonly StoreDBContext _db;
        public ProductsController(StoreDBContext db)
        {
            _db=db;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _db.Products.ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<Product>>GetProduct(int id){
            return await _db.Products.FindAsync(id);
        }
    }
}