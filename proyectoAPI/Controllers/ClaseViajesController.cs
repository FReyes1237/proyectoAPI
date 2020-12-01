using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.ClaseViaje;

namespace proyectoAPI.Controllers
{
    [Route("api/[Controller]")]

    public class ClaseViajesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClaseViajesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClaseViaje>>> Get()
        {
            return await _mediator.Send(new Consulta.ListaClaseViaje());
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
    }
}
