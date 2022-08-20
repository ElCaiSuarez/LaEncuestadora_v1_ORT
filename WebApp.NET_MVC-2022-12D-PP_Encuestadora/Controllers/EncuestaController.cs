using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Context;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Controllers
{
    public class EncuestaController : Controller
    {
        private readonly EncuestadoraDBContext _context;

        public EncuestaController(EncuestadoraDBContext context)
        {
            _context = context;
        }

        // GET: encuestas
        public async Task<IActionResult> Index()
        {
            var encuestadoraDBContext = _context.encuestas.Include(e => e.Cliente);
            return View(await encuestadoraDBContext.ToListAsync());
        }

        //METODO DISPONIBLE Copia de Index 15/06/2022
        public async Task<IActionResult> Disponibles(int UsuarioId)
        {
            var encuestadoraDBContext = _context.encuestas.Include(e => e.preguntas).ThenInclude(e => e.opciones);
            ViewBag.UsuarioId = UsuarioId;
            return View(await encuestadoraDBContext.ToListAsync());
        }

        //METODO RESPONDER Copia de Details 16/06/2022 con Include y ThenInclude
        public async Task<IActionResult> Responder(int? id)
        {
            {
                if (id == null)
                {
                    return NotFound();
                }

                var encuesta = await _context.encuestas
                    .Include(e => e.preguntas)
                    .ThenInclude(s => s.opciones)
                    .FirstOrDefaultAsync(m => m.EncuestaId == id);
                if (encuesta == null)
                {
                    return NotFound();
                }

                return View(encuesta);
            }
        }

        //METODO DETAILS 16/06/2022 con Include y ThenInclude
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas
                .Include(e => e.preguntas)
                .ThenInclude(f => f.opciones)
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuesta == null)
            {
                return NotFound();
            }

            return View(encuesta);
        }

        //METODO GET CREATE con ViewBag, Parametro ClienteId y automatizaciones 29/06/2022
        //GET
        public IActionResult Create(int ClienteId)
        {
            var encuesta = new Encuesta();
            var dias = 7;
            encuesta.datetimeCreacionEncuesta = DateTime.Now;
            var cliente = _context.clientes.Single(i => i.ClienteId == ClienteId);
            ViewBag.cliente = cliente;
            ViewBag.puntosEncuesta = PuntosEncuesta.ENCUESTA_GRATIS;
            var precioCliente = cliente.precioCliente;
            if (precioCliente == PrecioCliente.CLIENTE_ORO)
            {
                ViewBag.puntosEncuesta = PuntosEncuesta.ENCUESTA_ORO;
                dias = 21;
            }
            else if (precioCliente == PrecioCliente.CLIENTE_PLATA)
            {
                ViewBag.puntosEncuesta = PuntosEncuesta.ENCUESTA_PLATA;
                dias = 15;
            }
            encuesta.datetimeVencimientoEncuesta = encuesta.datetimeCreacionEncuesta.AddDays(dias);
            //ViewData["Clientes"] = new SelectList(_context.clientes.ToList(), "ClienteId", "nombreCliente");
            return View(encuesta);
        }

        //METODO POST CREATE con ViewBag 29/06/2022
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EncuestaId,tituloEncuesta,datetimeCreacionEncuesta,datetimeVencimientoEncuesta,puntosEncuesta,ClienteId")] Encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(encuesta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Encuesta", new { id = encuesta.EncuestaId });
            }
            ViewBag.ClienteId = encuesta.ClienteId;
            //ViewData["Clientes"] = new SelectList(_context.clientes, "ClienteId", "nombreCliente", encuesta.ClienteId);
            return View(encuesta);
        }

        // GET: Encuesta/Edit/5
        public async Task<IActionResult> Edit(int? id, int ClienteId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas.FindAsync(id);
            if (encuesta == null)
            {
                return NotFound();
            }
            var cliente = _context.clientes.Single(i => i.ClienteId == ClienteId);
            ViewBag.cliente = cliente;
            //ViewData["ClienteId"] = new SelectList(_context.clientes, "ClienteId", "nombreCliente", encuesta.ClienteId);
            return View(encuesta);
        }

        // POST: Encuesta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EncuestaId,tituloEncuesta,datetimeCreacionEncuesta,datetimeVencimientoEncuesta,puntosEncuesta,ClienteId")] Encuesta encuesta)
        {
            //if (id != encuesta.EncuestaId)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(encuesta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EncuestaExists(encuesta.EncuestaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Cliente", new { id = encuesta.ClienteId });
            }
            ViewBag.ClienteId = encuesta.ClienteId;
            //ViewData["ClienteId"] = new SelectList(_context.clientes, "ClienteId", "nombreCliente", encuesta.ClienteId);
            return View(encuesta);
        }

        // GET: Encuesta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuesta = await _context.encuestas
                .Include(e => e.Cliente)
                .FirstOrDefaultAsync(m => m.EncuestaId == id);
            if (encuesta == null)
            {
                return NotFound();
            }

            return View(encuesta);
        }

        // POST: Encuesta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encuesta = await _context.encuestas.FindAsync(id);
            _context.encuestas.Remove(encuesta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Cliente", new { id = encuesta.ClienteId });
        }

        private bool EncuestaExists(int id)
        {
            return _context.encuestas.Any(e => e.EncuestaId == id);
        }
    }
}
