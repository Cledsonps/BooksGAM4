using BooksGAM4.Models;
using System.Collections.Generic;
using System.Linq;

namespace BooksGAM4.Data.DAL
{
    public class LivroDAL : Livro
    {
        private readonly ApplicationDbContext _context;
        public LivroDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lista todos os livros da Tabela Livros
        /// </summary>
        public static List<Livro> ListaLivro(ApplicationDbContext context)
        {
            return context.Livros.ToList();
        }
    }
}