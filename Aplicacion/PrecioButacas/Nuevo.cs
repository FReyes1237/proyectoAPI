using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.PrecioButacas
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public int claseViajeID { get; set; }

            public int vueloID { get; set; }

            public float precio { get; set; }

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
                var preciob = new Dominio.precioButaca
                {
                    claseViajeID = request.claseViajeID,
                    vueloID = request.vueloID,
                    precio = request.precio
                };

                _context.precioButaca.Add(preciob);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("Error al definir precio");

            }
        }
    }
}
