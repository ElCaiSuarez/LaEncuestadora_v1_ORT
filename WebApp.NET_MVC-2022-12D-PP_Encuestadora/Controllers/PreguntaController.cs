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
    public class PreguntaController : Controller
    {
        private readonly EncuestadoraDBContext _context;

        public PreguntaController(EncuestadoraDBContext context)
        {
            _context = context;
        }

        // GET: Pregunta
        public async Task<IActionResult> Index()
        {
            var encuestadoraDBContext = _context.preguntas.Include(p => p.Encuesta);
            return View(await encuestadoraDBContext.ToListAsync());
        }
        //metodo redirigido 29/06/2022
        // GET: Pregunta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var pregunta = await _context.preguntas
                .Include(p => p.Encuesta)
                .FirstOrDefaultAsync(m => m.PreguntaId == id);
            //if (pregunta == null)
            //{
            //    return NotFound();
            //}

            //return View(pregunta);
            return RedirectToAction("Details", "Encuesta", new { id = pregunta.EncuestaId });
        }

        // GET: Pregunta/Create
        public IActionResult Create(int EncuestaId)
        {
            var encuesta = _context.encuestas.Single(i => i.EncuestaId == EncuestaId);
            ViewBag.encuesta = encuesta;
            //ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta");
            return View();
        }

        // POST: Pregunta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PreguntaId,tituloPregunta,tipoPregunta,EncuestaId")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pregunta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Encuesta", new { id = pregunta.EncuestaId });
                //<a href="/Encuesta/Details/@ViewBag.encuesta.EncuestaId">Volver a la Encuesta</a>
            }
            ViewBag.EncuestaId = pregunta.EncuestaId;
            //ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", pregunta.EncuestaId);
            return View(pregunta);
        }

        // GET: Pregunta/Edit/5
        public async Task<IActionResult> Edit(int? id, int EncuestaId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.preguntas.FindAsync(id);
            if (pregunta == null)
            {
                return NotFound();
            }
            var encuesta = _context.encuestas.Single(i => i.EncuestaId == EncuestaId);
            ViewBag.encuesta = encuesta;
            //ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", pregunta.EncuestaId);
            return View(pregunta);
        }

        // POST: Pregunta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PreguntaId,tituloPregunta,tipoPregunta,EncuestaId")] Pregunta pregunta)
        {
            //if (id != pregunta.PreguntaId)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pregunta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreguntaExists(pregunta.PreguntaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Encuesta", new { id = pregunta.EncuestaId });
            }
            ViewBag.EncuestaId = pregunta.EncuestaId;
            //ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", pregunta.EncuestaId);
            return View(pregunta);
        }

        // GET: Pregunta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.preguntas
                .Include(p => p.Encuesta)
                .FirstOrDefaultAsync(m => m.PreguntaId == id);
            if (pregunta == null)
            {
                return NotFound();
            }

            return View(pregunta);
        }

        // POST: Pregunta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pregunta = await _context.preguntas.FindAsync(id);
            _context.preguntas.Remove(pregunta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Encuesta", new { id = pregunta.EncuestaId });
        }

        private bool PreguntaExists(int id)
        {
            return _context.preguntas.Any(e => e.PreguntaId == id);
        }
    }
}
