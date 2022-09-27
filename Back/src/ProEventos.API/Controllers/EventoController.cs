using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _contex;

        public EventoController(DataContext contex)
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
