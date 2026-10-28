using GestionProductosWebAPI.DTOs;
using GestionProductosWebAPI.Models;
using GestionProductosWebAPI.Repositories;
using System.Collections.Generic;

namespace GestionProductosWebAPI.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            _repository = repository;
        }

        public List<Producto> ObtenerTodosLosProductos() => _repository.ObtenerTodos();

        public Producto? ObtenerProductoPorId(int id) => _repository.ObtenerPorId(id);

        public List<Producto> ObtenerPorCategoria(string categoria) => _repository.BuscarPorCategoria(categoria);

        public Producto CrearProducto(ProductoCreateDto dto)
        {
            var nuevoProducto = new Producto
            {
                Nombre = dto.Nombre,
                Precio = dto.Precio,
                Categoria = dto.Categoria,
                Activo = true
            };

            _repository.Agregar(nuevoProducto);
            return nuevoProducto;
        }
    }
}
