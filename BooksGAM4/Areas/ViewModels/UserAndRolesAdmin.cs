using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksGAM4.Areas.ViewModels
{
    public class UserAndRolesAdmin
    {
        [DisplayName("Identificação")]
        public string UserId { get; set; }

        [Required]
        [DisplayName("Usuário")]
        public string UserName { get; set; }

        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Grupo")]
        public string RoleName { get; set; }

        [DisplayName("Grupo")]
        public string RoleId { get; set; }
    }
}
