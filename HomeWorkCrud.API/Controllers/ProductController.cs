﻿using HomeWorkCrud.API.Data;
using HomeWorkCrud.API.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkCrud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        
            private readonly HomeWorkDbContext _context;

            public ProductController(HomeWorkDbContext context)
            {
                _context = context;
            }

            // GET: api/Products
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
            {
                return await _context.Products.ToListAsync();
            }

            // GET: api/Products/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Product>> GetProduct(int id)
            {
                var product = await _context.Products.FindAsync(id);

                if (product == null)
                {
                    return NotFound();
                }

                return product;
            }

            // PUT: api/Products/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutProduct(int id, Product product)
            {
                if (id != product.ProductId)
                {
                    return BadRequest();
                }

                _context.Entry(product).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }

            // POST: api/Products
            [HttpPost]
            public async Task<ActionResult<Product>> PostProduct(Product product)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                return Ok();
            }

            // DELETE: api/Products/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteProduct(int id)
            {
                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool ProductExists(int id)
            {
                return _context.Products.Any(e => e.ProductId == id);
            }

        }
    
}
