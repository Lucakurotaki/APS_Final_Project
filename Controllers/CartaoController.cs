#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using APS_Final_Project.Models;

namespace APS_Final_Project.Controllers
{
    public class CartaoController : Controller
    {
        private readonly MyDbContext _context;

        public CartaoController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Cartao
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartoesDeCredito.ToListAsync());
        }

        // GET: Cartao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoDeCredito = await _context.CartoesDeCredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartaoDeCredito == null)
            {
                return NotFound();
            }

            return View(cartaoDeCredito);
        }

        // GET: Cartao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cartao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero,Validade,Cvc")] CartaoDeCredito cartaoDeCredito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartaoDeCredito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartaoDeCredito);
        }

        // GET: Cartao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoDeCredito = await _context.CartoesDeCredito.FindAsync(id);
            if (cartaoDeCredito == null)
            {
                return NotFound();
            }
            return View(cartaoDeCredito);
        }

        // POST: Cartao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero,Validade,Cvc")] CartaoDeCredito cartaoDeCredito)
        {
            if (id != cartaoDeCredito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartaoDeCredito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartaoDeCreditoExists(cartaoDeCredito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cartaoDeCredito);
        }

        // GET: Cartao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoDeCredito = await _context.CartoesDeCredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartaoDeCredito == null)
            {
                return NotFound();
            }

            return View(cartaoDeCredito);
        }

        // POST: Cartao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartaoDeCredito = await _context.CartoesDeCredito.FindAsync(id);
            _context.CartoesDeCredito.Remove(cartaoDeCredito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartaoDeCreditoExists(int id)
        {
            return _context.CartoesDeCredito.Any(e => e.Id == id);
        }
    }
}
