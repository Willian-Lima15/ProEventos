﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {   
        private readonly ProEventosContext _context;
        public EventosController(ProEventosContext context)
        {            
           _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }
         [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return _context.Eventos.FirstOrDefault(evento => evento.Id == id);
        }
        [HttpPost]
        public IEnumerable<Evento> Post()
        {
           return _context.Eventos;
        }
        [HttpPut]
        public IEnumerable<Evento> Put()
        {
           return _context.Eventos;
        }
    }
}
