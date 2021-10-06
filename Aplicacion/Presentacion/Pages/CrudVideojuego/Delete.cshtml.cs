using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudVideojuego
{
    public class DeleteModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public DeleteModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Videojuego Videojuego { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Videojuego = await _context.Videojuegos.FirstOrDefaultAsync(m => m.id == id);

            if (Videojuego == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Videojuego = await _context.Videojuegos.FindAsync(id);

            if (Videojuego != null)
            {
                _context.Videojuegos.Remove(Videojuego);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
