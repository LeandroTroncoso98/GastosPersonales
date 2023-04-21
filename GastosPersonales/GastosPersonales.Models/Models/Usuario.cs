using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.Models.Models
{
    public class Usuario
    {
        [Key]
        public int Usuario_Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorío.")]
        public string NombreUsuario { get; set; }
        [EmailAddress(ErrorMessage = "Email no valído.")]
        [Required(ErrorMessage = "Campo obligatorío.")]
        public string CorreoElectronico { get; set; }
        [StringLength(25,ErrorMessage = "La contraseña debe debe poseer entre 12 y 25 caracteres.",MinimumLength = 12)]
        [Required(ErrorMessage = "Campo obligatorío.")]
        public string Contraseña { get; set; }
        public List<Transaccion> Transacciones { get; set; }
    }
}
