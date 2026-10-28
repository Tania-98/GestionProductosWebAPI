using GestionProductosWebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestionProductosWebAPI.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        // Lista en memoria simulando una base de datos
        private static readonly List<Producto> _productos = new()
        {
            new Producto { Id = 1, Nombre = "Binoculares Pro", Precio = 45000m, Categoria = "Equipamiento", Activo = true },
            new Producto { Id = 2, Nombre = "Guía de Flora y Fauna del Litoral", Precio = 12000m, Categoria = "Librería", Activo = true },
            new Producto { Id = 3, Nombre = "Mochila Impermeable 30L", Precio = 65000m, Categoria = "Equipamiento", Activo = true },
            new Producto { Id = 4, Nombre = "Cantimplora Térmica", Precio = 18500m, Categoria = "Accesorios", Activo = false }
        };

        public List<Producto> ObtenerTodos() => _productos;

        public Producto? ObtenerPorId(int id) => _productos.FirstOrDefault(p => p.Id == id);

        public List<Producto> BuscarPorCategoria(string categoria) =>
            _productos.Where(p => p.Categoria.Equals(categoria, System.StringComparison.OrdinalIgnoreCase)).ToList();

        public void Agregar(Producto producto)
        {
            producto.Id = _productos.Count > 0 ? _productos.Max(p => p.Id) + 1 : 1;
            _productos.Add(producto);
        }
    }
}