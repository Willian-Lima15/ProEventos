using System;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public IEnumerable<Lote> Lote { get; set; }
        public string ImageURL { get; set; }
        public string Telefona { get; set; }
        public string email { get; set; }
        public IEnumerable<RedeSocial> RedeSocial { get; set; }
    }
}