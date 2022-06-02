using FransfordSystem.Models;
using FransfordSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FransfordSystem.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly FransforDbContext _context;
        private readonly UserManager<Usuario> _userManager;
        public UsuarioController(FransforDbContext context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            return _context.Usuario != null ?
                        View(await _context.Usuario.ToListAsync()) :
                        Problem("Entity set 'FransforDbContext.Cliente'  is null.");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id,nombreTrabajador,apellidoTrabajador,fechaNacimiento,genero,dui,cuentaBancaria,UserName,Email,PasswordHash")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }




    }
}
