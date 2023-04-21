using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.Models.Models
{
    public class Categoria
    {
        [Key]
        public int Categoria_Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorío.")]
        [DisplayName("Nombre de la categoría")]
        public string NombreCategoria { get; set; }
        public List<Transaccion> Transacciones { get; set; }
        
    }
}
