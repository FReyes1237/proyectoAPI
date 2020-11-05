using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Aeronaves
{
    public class ConsultaId
    {
        public class AeronaveUnico:IRequest<Aeronave>
        {
            public int Id { get; set; }
        }

        public class Manejador : IRequestHandler<AeronaveUnico, Aeronave>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<Aeronave> Handle(AeronaveUnico request, CancellationToken cancellationToken)
            {
                var aeronave = await _context.Aeronave.FindAsync(request.Id);
                return aeronave;
            }
        }
    }
}
