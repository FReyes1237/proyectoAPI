using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Butaca
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public int AeronaveID { get; set; }
            public int ClaseViajeID { get; set; }
            public int EstadoButacaID { get; set; }
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
                var butaca = new Dominio.Butaca
                {
                    aeronaveID = request.AeronaveID,
                    claseViajeID = request.ClaseViajeID,
                    estadoButacaID = request.EstadoButacaID
                };

                _context.Butaca.Add(butaca);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo agregar la Butaca");

            }
        }
    }
}
