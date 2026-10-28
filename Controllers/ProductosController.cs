using GestionProductosWebAPI.DTOs;
using GestionProductosWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionProductosWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductosController(IProductoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var productos = _service.ObtenerTodosLosProductos();
            return Ok(productos);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var producto = _service.ObtenerProductoPorId(id);
            if (producto == null)
            {
                return NotFound(new { mensaje = $"No se encontró el producto con ID {id}." });
            }
            return Ok(producto);
        }

        [HttpGet("categoria/{categoria}")]
        public IActionResult GetByCategory(string categoria)
        {
            var productos = _service.ObtenerPorCategoria(categoria);
            return Ok(productos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductoCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var creado = _service.CrearProducto(dto);
            return CreatedAtAction(nameof(GetById), new { id = creado.Id }, creado);
        }
    }
}
