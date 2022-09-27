
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEvento.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _contex;

        public EventosController(DataContext contex)
        {
            _contex= contex;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _contex.Eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _contex.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }
    }
}
