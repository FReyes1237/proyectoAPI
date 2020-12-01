using Aplicacion.EstadoVuelos;
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

    public class EstadoVuelosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EstadoVuelosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<ActionResult<List<estadoVuelo>>> Get()
        {
            return await _mediator.Send(new Consulta.ListaestadoVuelo());
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
    }
}
