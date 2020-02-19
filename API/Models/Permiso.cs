using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("Permiso", Schema = "dbo")]
    public class Permiso
    {
        [Key]
        public int PermisoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public int TipoPermisoId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
