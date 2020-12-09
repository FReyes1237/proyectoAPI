using Aplicacion.ManejadorError;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Aeronaves

{
    public class Eliminar
    {
        public class Ejecuta : IRequest
        {
            public int aeronaveID { get; set; }
            public String Modelo { get; set; }
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
                var nave = await _context.Aeronave.FindAsync(request.aeronaveID);
                if (nave == null)
                {
                    //throw new Exception("No es posible eliminar la aeronave");
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { curso = "La aeronave no existe" });
                }

                _context.Remove(nave);

                var resultado = await _context.SaveChangesAsync();
                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudieron guardar los cambios");
            }
        }
    }
}

