using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Dtos
{
    public class ProductoDto
    {
        [Key]
        [Column("ProductoId")]
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        [Column("CategoriaId")]
        public string Categoria { get; set; }
        [Column("MarcaId")]
        public string Marca { get; set; }
    }
}