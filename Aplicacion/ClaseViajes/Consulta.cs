using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.ClaseViajes
{
    class Consulta
    {
        public class ListaClaseViaje : IRequest<List<Dominio.ClaseViaje>> { }

        public class Manejador : IRequestHandler<ListaClaseViaje, List<Dominio.ClaseViaje>>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<List<Dominio.ClaseViaje>> Handle(ListaClaseViaje request, CancellationToken cancellationToken)
            {
                var claseviaje = await _context.ClaseViaje.ToListAsync();
                return claseviaje;
            }
        }
    }
}
