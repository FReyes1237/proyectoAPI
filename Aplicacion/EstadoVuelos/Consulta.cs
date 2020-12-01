using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.EstadoVuelos
{
    public class Consulta
    {
        public class ListaestadoVuelo : IRequest<List<Dominio.estadoVuelo>> { }

        public class Manejador : IRequestHandler<ListaestadoVuelo, List<Dominio.estadoVuelo>>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<List<Dominio.estadoVuelo>> Handle(ListaestadoVuelo request, CancellationToken cancellationToken)
            {
                var estadovuelos = await _context.estadoVuelo.ToListAsync();
                return estadovuelos;
            }
        }
    }
}
