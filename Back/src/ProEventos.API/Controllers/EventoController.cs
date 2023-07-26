using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController  : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
      new Evento(){
          EventoId = 1,
          Tema= "Angular e .NET",
          Local = "Belo Horizonte",
          Lote = "1º Lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
          ImagemUrl = "foto.png"
        },
        new Evento(){
          EventoId = 2,
          Tema= "Angular",
          Local = "São Paulo",
          Lote = "2º Lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
          ImagemUrl = "foto1.png"
        },
    };
    public EventoController (ILogger<EventoController > logger)
    {
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento>  GetById(int id)
    {
      return _evento.Where(evento => evento.EventoId == id);
    }
    }
