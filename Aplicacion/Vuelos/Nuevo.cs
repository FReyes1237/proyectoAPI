using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Vuelos
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public int estadoVueloID { get; set; }

            public int calendarioID { get; set; }

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
                var vuelo = new Dominio.Vuelo
                {
                    estadoVueloID = request.estadoVueloID,
                    calendarioID = request.calendarioID
                };

                _context.Vuelo.Add(vuelo);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se logró agendar el vuelo");

            }
        }
    }
}
