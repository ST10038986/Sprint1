﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sprint1_EpicBookstoreApplication.Data;
using Sprint1_EpicBookstoreApplication.Models;

namespace Sprint1_EpicBookstoreApplication.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICartService _cartServices;

        public InventoriesController(ApplicationDbContext context, ICartService cartService)
        {
            _context = context;
            _cartServices = cartService;
        }

        // GET: Inventories
        public async Task<IActionResult> Index()
        {
            return _context.Inventory != null ?
                        View(await _context.Inventory.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Inventory' is null.");
        }

        // GET: Inventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Inventory == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var itemToAdd = await _context.Inventory.FindAsync(id);

            if (itemToAdd != null)
            {
                _cartServices.AddItemToCart(itemToAdd);
                return RedirectToAction(nameof(Index));
            }

            return NotFound;
        }
    

        // GET: Inventories/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Inventories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,BookName,AuthorName,BookGenre,ISBN,Stock")] Inventory inventory)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(inventory);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(inventory);
        //}

        //// GET: Inventories/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Inventory == null)
        //    {
        //        return NotFound();
        //    }

        //    var inventory = await _context.Inventory.FindAsync(id);
        //    if (inventory == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(inventory);
        //}

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,BookName,AuthorName,BookGenre,ISBN,Stock")] Inventory inventory)
        //{
        //    if (id != inventory.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(inventory);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!InventoryExists(inventory.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(inventory);
        //}

        //// GET: Inventories/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Inventory == null)
        //    {
        //        return NotFound();
        //    }

        //    var inventory = await _context.Inventory
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (inventory == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(inventory);
        //}

        //// POST: Inventories/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Inventory == null)
        //    {
        //        return Problem("Entity set 'ApplicationDbContext.Inventory'  is null.");
        //    }
        //    var inventory = await _context.Inventory.FindAsync(id);
        //    if (inventory != null)
        //    {
        //        _context.Inventory.Remove(inventory);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool InventoryExists(int id)
        {
          return (_context.Inventory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
