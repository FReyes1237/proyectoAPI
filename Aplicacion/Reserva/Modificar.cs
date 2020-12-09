using Aplicacion.ManejadorError;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Reserva
{
    public class Modificar
    {
        public class Ejecuta : IRequest
        {
            public int ReservaID { get; set; }

            public string ClienteID { get; set; }

            public int butacaID { get; set; }

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
                var reserva = await _context.Reserva.FindAsync(request.ReservaID);

                if (reserva == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { reserva = "La reserva no existe" });
                }

                //reserva.butacaID = request.butacaID ?? reserva.butacaID;


                var resultado = await _context.SaveChangesAsync();
                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("Los cambios no se guardaron");
            }
        }
    }
}
