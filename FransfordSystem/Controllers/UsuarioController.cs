using FransfordSystem.Models;
using FransfordSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FransfordSystem.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly FransforDbContext _context;
        private readonly UserManager<Usuario> _userManager;
        private readonly IUserStore<Usuario> _userStore;
        private readonly IUserEmailStore<Usuario> _emailStore;


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
        public async Task<IActionResult> registarUsuarioPost(RegistrarUsuarioViewModel nuevo)
        {
          
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario();
                usuario.nombreTrabajador = nuevo.nombreUsuario;
                usuario.UserName = nuevo.nombreUsuario;
                usuario.fechaNacimiento = nuevo.fechaNac;
                usuario.apellidoTrabajador = nuevo.apellido;
                usuario.Email = nuevo.correo;
                usuario.EmailConfirmed = true;
                usuario.dui = nuevo.dui;
                usuario.cuentaBancaria = nuevo.cuentaBancaria;
                usuario.genero = nuevo.genero;

                var result = await _userManager.CreateAsync(usuario,nuevo.contra);
                    return RedirectToAction("Index");
                             
            }
            return View();
        }



        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            EditarViewModel editUsu = new EditarViewModel();
            editUsu.id = usuario.Id;
            editUsu.nombre = usuario.nombreTrabajador;
            editUsu.nombreUsuario = usuario.UserName;
            editUsu.fechaNac = usuario.fechaNacimiento;
            editUsu.apellido = usuario.apellidoTrabajador;
            editUsu.correo = usuario.Email;
            editUsu.dui = usuario.dui;
            editUsu.cuentaBancaria = usuario.cuentaBancaria;
            editUsu.genero = usuario.genero;


            return View(editUsu);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditarViewModel nuevo)
        {



            if (ModelState.IsValid)
            {

                Usuario usuario = await _userManager.FindByIdAsync(nuevo.id);
                usuario.nombreTrabajador = nuevo.nombre;
                usuario.UserName = nuevo.nombreUsuario;
                usuario.fechaNacimiento = nuevo.fechaNac;
                usuario.apellidoTrabajador = nuevo.apellido;
                usuario.Email = nuevo.correo;
                usuario.dui = nuevo.dui;
                usuario.cuentaBancaria = nuevo.cuentaBancaria;
                usuario.genero = nuevo.genero;                               
                var result = await _userManager.UpdateAsync(usuario);
                return RedirectToAction("Index");

            }
            return View();
        }


    }
}
