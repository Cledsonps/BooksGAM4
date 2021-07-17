using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksGAM4.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [DisplayName("Imagem")]
        public string ImagemCapaUrl { get; set; }

        [Column(TypeName = "varchar(13)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        public string ISBN { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        public string Editora { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        public string Autor { get; set; }

        [StringLength(2000)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        public string Sinopse { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [DisplayName("Data da Publicação")]
        public DateTime DataPublicacao { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [DisplayName("Preço")]
        public decimal Preco { get; set; }
    }
}
