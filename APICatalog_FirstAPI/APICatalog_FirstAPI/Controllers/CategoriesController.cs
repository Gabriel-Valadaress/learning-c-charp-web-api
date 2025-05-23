using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using APICatalog_FirstAPI.Context;
using APICatalog_FirstAPI.Models;

namespace APICatalog_FirstAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CatalogDbContext _context;

        public CategoriesController(CatalogDbContext context)
        {
            _context = context;
        }

        [HttpGet("products")]
        public ActionResult<IEnumerable<Category>> GetCategoriesProducts()
        {
            return _context.Categories.Include(p => p.Products).ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            var categories = _context.Categories.ToList();
            if (categories is null)
            {
                return NotFound();
            }
            return categories;
        }

        [HttpGet("{id:int}", Name = "GetCategory")]
        public ActionResult<Category> Get(int id)
        {
            var category = _context.Categories.FirstOrDefault(p => p.CategoryId == id);
            if (category is null)
            {
                return NotFound();
            }
            return category;
        }

        [HttpPost]
        public ActionResult Post(Category category)
        {
            if (category is null)
            {
                return BadRequest();
            }

            _context.Categories.Add(category);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetCategory",
                new { id = category.CategoryId }, category);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(category);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(p => p.CategoryId == id);
            if (category is null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();

            return Ok(category);
        }
    }
}
