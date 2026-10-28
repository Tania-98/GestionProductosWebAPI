using GestionProductosWebAPI.Models;
using System.Collections.Generic;

namespace GestionProductosWebAPI.Repositories
{
    public interface IProductoRepository
    {
        List<Producto> ObtenerTodos();
        Producto? ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
        void Agregar(Producto producto);
    }
}
