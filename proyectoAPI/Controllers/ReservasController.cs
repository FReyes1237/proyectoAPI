using Aplicacion.Reserva;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoAPI.Controllers
{
    [Route("api/[Controller]")]
    public class ReservasController:ControllerBase
    {
        private readonly IMediator _mediator;
        public ReservasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Reserva>>> Get()
        {
            return await _mediator.Send(new Consulta.ListaClaseReserva());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> Detalle(int id)
        {
            return await _mediator.Send(new ConsultaId.ReservaUnica { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Modificar(int id, Modificar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Eliminar(int id)
        {
            return await _mediator.Send(new Eliminar.Ejecuta { ReservaID = id });
        }
    }
}
