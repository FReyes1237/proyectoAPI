using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using MediatR;
using Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Reserva
{
    public class ConsultaId
    {
        public class ReservaUnica : IRequest<Dominio.Reserva>
        {
            public int Id { get; set; }
        }

        public class Manejador : IRequestHandler<ReservaUnica, Dominio.Reserva>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<Dominio.Reserva> Handle(ReservaUnica request, CancellationToken cancellationToken)
            {
                var reserva = await _context.Reserva.FindAsync(request.Id);
                return reserva;
            }
        }
    }
}
