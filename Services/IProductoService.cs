using GestionProductosWebAPI.DTOs;
using GestionProductosWebAPI.Models;
using System.Collections.Generic;

namespace GestionProductosWebAPI.Services
{
    public interface IProductoService
    {
        List<Producto> ObtenerTodosLosProductos();
        Producto? ObtenerProductoPorId(int id);
        List<Producto> ObtenerPorCategoria(string categoria);
        Producto CrearProducto(ProductoCreateDto dto);
    }
}
