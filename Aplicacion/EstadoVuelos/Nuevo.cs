using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.EstadoVuelos
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public String nombreEstado { get; set; }

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
                var estadoV = new Dominio.estadoVuelo
                {
                    nombreEstado = request.nombreEstado,
                };

                _context.estadoVuelo.Add(estadoV);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo guardar el estado");

            }
        }
    }
}
