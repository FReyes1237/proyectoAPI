using Aplicacion.Butaca;
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
    public class ButacasController: ControllerBase
    {
        private readonly IMediator _mediator;
        public ButacasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Butaca>>> Get()
        {
            return await _mediator.Send(new Consulta.ListaButaca());
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
    }
}
