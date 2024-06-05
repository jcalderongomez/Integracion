using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entidades
{
[Table("Categoria")]
    public class Categoria
    {
        [Key]
        [Column("CategoriaId")]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre de la categoría es requerido")]
        public string Nombre{ get; set; }
        
    }
}