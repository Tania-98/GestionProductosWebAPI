using System.ComponentModel.DataAnnotations;

namespace GestionProductosWebAPI.DTOs
{
    public class ProductoCreateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Range(0.01, 1000000, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public string Categoria { get; set; } = string.Empty;
    }
}
