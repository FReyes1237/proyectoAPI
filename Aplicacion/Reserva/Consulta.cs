using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Reserva
{
    class Consulta
    {
        public class ListaClaseReserva : IRequest<List<Dominio.Reserva>> { }

        public class Manejador : IRequestHandler<ListaClaseReserva, List<Dominio.Reserva>>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<List<Dominio.Reserva>> Handle(ListaClaseReserva request, CancellationToken cancellationToken)
            {
                var reserva = await _context.Reserva.ToListAsync();
                return reserva;
            }
        }
    }
}
