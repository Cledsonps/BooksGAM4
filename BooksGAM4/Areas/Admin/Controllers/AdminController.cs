using BooksGAM4.Areas.ViewModels;
using BooksGAM4.Data;
using BooksGAM4.Models;
using BooksGAM4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksGAM4.Areas.Admin.Controllers
{
    //[Authorize(Roles ="Administrador")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Area("Admin")]        
        public IActionResult Index()
        {
            if (User.IsInRole("Administrador"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("AcessoNegado", "Admin");
            }
            
        }

        //--    Actions de AdminUsuário
        [Area("Admin")]
        [Route("Usuario")]
        public ActionResult<IEnumerable> Usuario()
        {
            return View(new IdentityServices().Listagem());
        }

        //[Area("Admin")]
        //[Route("Usuario")]
        //public ActionResult<IEnumerable> Edit(string userName)
        //{
        //    return View(new IdentityServices().Listagem());
        //}

        //--    ( fim ) das Actions de AdminUsuário

        //--    Tela de Acesso Negado
        [Area("Admin")]
        [Route("AcessoNegado")]
        public IActionResult AcessoNegado()
        {
            return View();
        }
    }
}
