using Aplicacion.PrecioButacas;
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

    public class PrecioButacasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PrecioButacasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<ActionResult<List<precioButaca>>> Get()
        {
            return await _mediator.Send(new Consulta.ListaPrecioB());
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
    }
}
