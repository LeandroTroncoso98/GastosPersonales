using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.Models.Models
{
    public class Transaccion
    {
        [Key]
        public int Transaccion_Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorío.")]
        public DateTime FechaDeTransaccion { get; set; }
        public float MontoDeTransaccion { get; set; }
        [ForeignKey("Usuario")]
        public int Usuario_Id { get; set; }
        public Usuario Usuario { get; set; }
        [ForeignKey("Categoria")]
        public int Categoria_Id { get; set; }
        public Categoria Categoria { get; set; }
    }
}
