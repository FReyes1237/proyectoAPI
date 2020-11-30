using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Vuelos
{
    class Consulta
    {
        public class ListaVuelo : IRequest<List<Dominio.Vuelo>> { }

        public class Manejador : IRequestHandler<ListaVuelo, List<Dominio.Vuelo>>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<List<Dominio.Vuelo>> Handle(ListaVuelo request, CancellationToken cancellationToken)
            {
                var vuelos = await _context.Vuelo.ToListAsync();
                return vuelos;
            }
        }
    }
}
