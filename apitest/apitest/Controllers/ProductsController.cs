using apitest.Data;
using apitest.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apitest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ProductsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var products = await _appDbContext.Products.ToListAsync();
                if (products != null)
                {

                    return Ok(products);
                }
                else { return BadRequest("No data"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BadRequest("There are something error");
        }

        [HttpPost]
        public async Task<IActionResult> addNew(Product product)
        {
            if (product == null)
            {
                return BadRequest("Invalid request");
            }
            try
            {
                _appDbContext.Products.Add(product);
                await _appDbContext.SaveChangesAsync();
                return Ok("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return BadRequest("There are something error");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getById(int id)
        {
            if (id < 1 || id == null)
            {
                return BadRequest("Id invalid");
            }
            try
            {
                var item = _appDbContext.Products.FindAsync(id);

                if (item == null)
                {
                    return NotFound("Item not found");
                }
                return Ok(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BadRequest("There are something error");
        }

        [HttpPut]
        public async Task<IActionResult> update(Product product)
        {
            if (product == null)
            {
                return BadRequest("Invalid request");
            }
            try
            {
                var item = await _appDbContext.Products.FindAsync(product.Id);

                if (item == null)
                {
                    return NotFound("Item not found");
                }

                item.Name = product.Name;
                item.Description = product.Description;

                _appDbContext.Products.Update(item);
                await _appDbContext.SaveChangesAsync();
                return Ok("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return BadRequest("There are something error");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            if (id < 1 || id == null)
            {
                return BadRequest("Id invalid");
            }
            try
            {
                var item = await _appDbContext.Products.FindAsync(id);

                if (item == null)
                {
                    return NotFound("Not found");
                }

                item.Description = "Deleted";

                _appDbContext.Products.Update(item);
                await _appDbContext.SaveChangesAsync();
                return Ok("Success");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return BadRequest("There are something error");
        }

        //    [HttpGet("customjoin")]
        //    public IActionResult CustomJoin()
        //    {
        //        // Write the custom SQL query to perform the join operation
        //        string sqlQuery = @"
        //    SELECT p.Id AS ProductId, p.Name AS ProductName, p.Price AS ProductPrice
        //    -- Add columns from other table and join conditions as needed
        //    -- For example:
        //    -- , c.Id AS CategoryId, c.Name AS CategoryName
        //    -- FROM Products AS p
        //    -- INNER JOIN Categories AS c ON p.CategoryId = c.Id
        //";

        //        // Execute the query using Entity Framework Core's FromSqlRaw method
        //        var result = _appDbContext.CustomResultModels.FromSqlRaw(sqlQuery).ToList();

        //        return Ok(result);
        //    }
    }
}
