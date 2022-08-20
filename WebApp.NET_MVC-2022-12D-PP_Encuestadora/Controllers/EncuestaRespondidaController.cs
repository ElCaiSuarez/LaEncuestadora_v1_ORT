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
    public class EncuestaRespondidaController : Controller
    {
        private readonly EncuestadoraDBContext _context;

        public EncuestaRespondidaController(EncuestadoraDBContext context)
        {
            _context = context;
        }

        // GET: EncuestaRespondida
        public async Task<IActionResult> Index()
        {
            var encuestadoraDBContext = _context.encuestasRespondidas.Include(e => e.Usuario).Include(e => e.encuesta).Include(e => e.opcionPregunta).Include(e => e.pregunta);
            return View(await encuestadoraDBContext.ToListAsync());
        }

        public async Task<IActionResult> Resultado(string searchString, int ClienteId)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewBag.ClienteId = ClienteId;
            var encuestasRespondidas = from s in _context.encuestasRespondidas.Include(e => e.Usuario).Include(e => e.encuesta).Include(e => e.opcionPregunta).Include(e => e.pregunta)
                                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                encuestasRespondidas = encuestasRespondidas.Where(s => s.encuesta.tituloEncuesta.Contains(searchString));
            }

            return View(await encuestasRespondidas.AsNoTracking().ToListAsync());
        }

        public async Task<IActionResult> Respuesta(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var encuestasRespondidas = from s in _context.encuestasRespondidas.Include(e => e.Usuario).Include(e => e.encuesta).Include(e => e.opcionPregunta).Include(e => e.pregunta)
                                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                encuestasRespondidas = encuestasRespondidas.Where(s => s.Usuario.nombreUsuario.Contains(searchString));
            }
            var usuario = _context.usuarios.Single(s => s.nombreUsuario.Contains(searchString));
            ViewBag.UsuarioId = usuario.UsuarioId;
            return View(await encuestasRespondidas.AsNoTracking().ToListAsync());
        }

        // GET: EncuestaRespondida/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestaRespondida = await _context.encuestasRespondidas
                .Include(e => e.Usuario)
                .Include(e => e.encuesta)
                .Include(e => e.opcionPregunta)
                .Include(e => e.pregunta)
                .FirstOrDefaultAsync(m => m.EncuestaRespondidaId == id);
            if (encuestaRespondida == null)
            {
                return NotFound();
            }

            return View(encuestaRespondida);
        }

        // GET: EncuestaRespondida/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario");
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta");
            ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion");
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta");
            return View();
        }

        // POST: EncuestaRespondida/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EncuestaRespondidaId,datetimeRespuestaEncuesta,EncuestaId,PreguntaId,OpcionPreguntaId,UsuarioId")] EncuestaRespondida encuestaRespondida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(encuestaRespondida);
                await _context.SaveChangesAsync();
                return RedirectToAction("ResponderPreguntas", "EncuestaRespondida", new { EncuestaId = encuestaRespondida.EncuestaId, UsuarioId = encuestaRespondida.UsuarioId });
            }
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario", encuestaRespondida.UsuarioId);
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestaRespondida.EncuestaId);
            ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion", encuestaRespondida.OpcionPreguntaId);
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", encuestaRespondida.PreguntaId);
            return View(encuestaRespondida);
        }

        public IActionResult ResponderPreguntas(int EncuestaId, int UsuarioId)
        {
            //OTRA OPCION ES QUE EN DISPONIBLES NO LA MUESTRE
            var usuario = _context.usuarios.Single(i => i.UsuarioId == UsuarioId);
            var encuesta = _context.encuestas
                    .Include(e => e.preguntas)
                    .ThenInclude(s => s.opciones)
                    .Single(m => m.EncuestaId == EncuestaId);
            var preguntas = encuesta.preguntas;
            var preguntasSinResponder = new List<Pregunta>();
            var preguntasinResponder = new Pregunta();
            var esEncuestaRespondida = false;
            ////Si no hay preguntas en la encuesta vuelve a disponibles
            //if (preguntas.Count > 0)
            //{
                foreach (Pregunta p in preguntas)
                {
                    //Si la pregunta ya fue contestada por el usuario no la agrego a la lista de preguntasSinResponder
                    if (!EncuestaRespondidaExists(encuesta.EncuestaId, usuario.UsuarioId, p.PreguntaId))
                    {
                        //Agrego la pregunta a la lista de preguntasSinResponder
                        preguntasSinResponder.Add(p);
                    }

                }
                //Si no hay preguntas sin responder en la encuesta vuelve a disponibles
                if (preguntasSinResponder.Count > 0 )
                {
                    preguntasinResponder = preguntasSinResponder.OfType<Pregunta>().FirstOrDefault();
                    if(preguntasSinResponder.Count == 1)
                    {
                        int puntos = (int)encuesta.puntosEncuesta;
                        usuario.sumarPuntosEncuesta(puntos);
                        _context.SaveChangesAsync();
                    }
                }                
                else
                {
                    esEncuestaRespondida = true;
                }
           // }
            var encuestaRespondida = new EncuestaRespondida();
            if (!esEncuestaRespondida)
            {
                encuestaRespondida.encuesta = encuesta;
                encuestaRespondida.EncuestaId = encuesta.EncuestaId;
                encuestaRespondida.Usuario = usuario;
                encuestaRespondida.UsuarioId = usuario.UsuarioId;
                encuestaRespondida.datetimeRespuestaEncuesta = DateTime.Now;
                encuestaRespondida.pregunta = preguntasinResponder;
                encuestaRespondida.PreguntaId = preguntasinResponder.PreguntaId;
                ViewData["OpcionPreguntaId"] = new SelectList(preguntasinResponder.opciones, "OpcionPreguntaId", "tituloOpcion");
            }
            ViewBag.esEncuestaRespondida = esEncuestaRespondida;
            ViewBag.UsuarioId = usuario.UsuarioId;
            return View(encuestaRespondida);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResponderPreguntas([Bind("EncuestaRespondidaId,datetimeRespuestaEncuesta,EncuestaId,PreguntaId,OpcionPreguntaId,UsuarioId")] EncuestaRespondida encuestaRespondida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(encuestaRespondida);
                await _context.SaveChangesAsync();
                return RedirectToAction("ResponderPreguntas", "EncuestaRespondida", new { EncuestaId = encuestaRespondida.EncuestaId, UsuarioId = encuestaRespondida.UsuarioId });
            }
            return View(encuestaRespondida);
        }



        // GET: EncuestaRespondida/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestaRespondida = await _context.encuestasRespondidas.FindAsync(id);
            if (encuestaRespondida == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario", encuestaRespondida.UsuarioId);
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestaRespondida.EncuestaId);
            ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion", encuestaRespondida.OpcionPreguntaId);
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", encuestaRespondida.PreguntaId);
            return View(encuestaRespondida);
        }

        // POST: EncuestaRespondida/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EncuestaRespondidaId,datetimeRespuestaEncuesta,EncuestaId,PreguntaId,OpcionPreguntaId,UsuarioId")] EncuestaRespondida encuestaRespondida)
        {
            if (id != encuestaRespondida.EncuestaRespondidaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(encuestaRespondida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EncuestaRespondidaExists(encuestaRespondida.EncuestaRespondidaId))
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
            ViewData["UsuarioId"] = new SelectList(_context.usuarios, "UsuarioId", "nombreUsuario", encuestaRespondida.UsuarioId);
            ViewData["EncuestaId"] = new SelectList(_context.encuestas, "EncuestaId", "tituloEncuesta", encuestaRespondida.EncuestaId);
            ViewData["OpcionPreguntaId"] = new SelectList(_context.opciones, "OpcionPreguntaId", "tituloOpcion", encuestaRespondida.OpcionPreguntaId);
            ViewData["PreguntaId"] = new SelectList(_context.preguntas, "PreguntaId", "tituloPregunta", encuestaRespondida.PreguntaId);
            return View(encuestaRespondida);
        }

        // GET: EncuestaRespondida/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encuestaRespondida = await _context.encuestasRespondidas
                .Include(e => e.Usuario)
                .Include(e => e.encuesta)
                .Include(e => e.opcionPregunta)
                .Include(e => e.pregunta)
                .FirstOrDefaultAsync(m => m.EncuestaRespondidaId == id);
            if (encuestaRespondida == null)
            {
                return NotFound();
            }

            return View(encuestaRespondida);
        }

        // POST: EncuestaRespondida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encuestaRespondida = await _context.encuestasRespondidas.FindAsync(id);
            _context.encuestasRespondidas.Remove(encuestaRespondida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EncuestaRespondidaExists(int id)
        {
            return _context.encuestasRespondidas.Any(e => e.EncuestaRespondidaId == id);
        }

        private bool EncuestaRespondidaExists(int EncuestaId, int UsuarioId, int PreguntaId)
        {
            return _context.encuestasRespondidas.Any(e => e.EncuestaId == EncuestaId && e.UsuarioId == UsuarioId && e.PreguntaId == PreguntaId);
        }
    }
}
