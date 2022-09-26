using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        private IEnumerable<Evento> _evento = new Evento[]{
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 1 suas ações",
                Local = "Belém",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(12).ToString()
            },            new Evento()
            {
                EventoId = 2,
                Tema = "C# e suas novidades",
                Local = "São paulo",
                Lote = "2° Lote",
                QtdPessoas = 499,
                DataEvento = DateTime.Now.AddDays(15).ToString()
            }
        };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }
    }
}
