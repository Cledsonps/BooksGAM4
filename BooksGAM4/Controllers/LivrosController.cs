using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BooksGAM4.Data;
using BooksGAM4.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using BooksGAM4.Services;
using Microsoft.AspNetCore.Authorization;

namespace BooksGAM4.Controllers
{
    [Authorize]
    public class LivrosController : Controller
    {
        IHostingEnvironment _appEnvironment;
        private readonly ApplicationDbContext _context;

        public LivrosController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _appEnvironment = env;
            _context = context;
        }

        // GET: Livros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Livros.ToListAsync());
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,ImagemCapaUrl,ISBN,Editora,Autor,Sinopse,DataPublicacao,Preco")] Livro livro, List<IFormFile> arquivos)
        {
            //-- Upload do Arquivo
            livro.ImagemCapaUrl = await LivroServices.EnviarArquivo(arquivos, _context, _appEnvironment);

            //--- Grava dados
            try
            {
                if (ModelState.IsValid)
                {
                    if (!string.IsNullOrEmpty(livro.ImagemCapaUrl))
                    {
                        _context.Add(livro);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return View(livro);
                    }
                }
                else
                {
                    return View(livro);
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Não foi possível gravar no banco de dados");
            }

            return View(livro);

        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,ImagemCapaUrl,ISBN,Editora,Autor,Sinopse,DataPublicacao,Preco")] Livro livro)
        {
            if (id != livro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.Id))
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
            return View(livro);
        }

        // GET: Livros/Delete/5
        //[Authorize(Roles ="Administrador")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (User.IsInRole("Administrador"))
            {
                if (id == null)
                {
                    return NotFound();
                }
                var livro = await _context.Livros
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (livro == null)
                {
                    return NotFound();
                }

                return View(livro);
            }
            else
            {
                return RedirectToAction("AcessoNegado", "Livros");
            }         
        }

        public IActionResult AcessoNegado()
        {
            return View();
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livros.Any(e => e.Id == id);
        }
    }
}
