using Aplicacion.Aeronaves;
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
    public class AeronavesController:ControllerBase
    {
        private readonly IMediator _mediator;
        public AeronavesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Aeronave>>> Get()
        {
            return await _mediator.Send(new Consulta.ListaAeronaves());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aeronave>> Detalle(int id)
        {
            return await _mediator.Send(new ConsultaId.AeronaveUnico { Id = id });
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
            return await _mediator.Send(new Eliminar.Ejecuta { aeronaveID = id });
        }



    }
}
