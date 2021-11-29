using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_gladia.Models;

namespace Api_gladia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Items_OrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public Items_OrderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Items_Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Items_Order>>> Gettbl_items_order()
        {
            return await _context.tbl_items_order.ToListAsync();
        }

        // GET: api/Items_Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Items_Order>> GetItems_Order(int id)
        {
            var items_Order = await _context.tbl_items_order.FindAsync(id);

            if (items_Order == null)
            {
                return NotFound();
            }

            return items_Order;
        }

        // PUT: api/Items_Order/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItems_Order(int id, Items_Order items_Order)
        {
            if (id != items_Order.fk_id_prod)
            {
                return BadRequest();
            }

            _context.Entry(items_Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Items_OrderExists(id))
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

        // POST: api/Items_Order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Items_Order>> PostItems_Order(Items_Order items_Order)
        {
            _context.tbl_items_order.Add(items_Order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItems_Order", new { id = items_Order.fk_id_prod }, items_Order);
        }

        // DELETE: api/Items_Order/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItems_Order(int id)
        {
            var items_Order = await _context.tbl_items_order.FindAsync(id);
            if (items_Order == null)
            {
                return NotFound();
            }

            _context.tbl_items_order.Remove(items_Order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Items_OrderExists(int id)
        {
            return _context.tbl_items_order.Any(e => e.fk_id_prod == id);
        }
    }
}
