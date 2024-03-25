using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                Id = 1,
                Tema = "Angular + C#",
                Local = "Belo horizonte",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "Foto.png"
                }, 
                new Evento(){
                Id = 2,
                Tema = "Angular + .net",
                Local = "Salvador",
                Lote = "2º lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "Foto.png"
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
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.Id == id);
        }
        [HttpPost]
        public IEnumerable<Evento> Post()
        {
           return _evento;
        }
        [HttpPut]
        public IEnumerable<Evento> Put()
        {
           return _evento;
        }
    }
}
