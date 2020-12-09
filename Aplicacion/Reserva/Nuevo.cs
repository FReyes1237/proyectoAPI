using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Reserva
{
    public class Nuevo
    {

        public class Ejecuta : IRequest
        {
            public int reservaID { get; set; }
            public string ClienteID { get; set; }
            public int ButacaID { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var reserva = new Dominio.Reserva
                {
                    reservaID = request.reservaID,
                    ClienteID = request.ClienteID,
                    butacaID = request.ButacaID
                };

                _context.Reserva.Add(reserva);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo agregar la Reserva");

            }
        }
    }
}

