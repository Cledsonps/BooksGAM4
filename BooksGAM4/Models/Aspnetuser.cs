using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksGAM4.Models
{
    public class Aspnetuser
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Usuário")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string RetunUrl { get; set; }
    }
}
