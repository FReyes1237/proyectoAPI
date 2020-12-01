using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.ClaseViajes
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public String nombreClase { get; set; }

            public String descripción { get; set; }

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
                var clasev = new Dominio.ClaseViaje
                {
                    nombreClase = request.nombreClase,
                    descripción = request.descripción
                };

                _context.ClaseViaje.Add(clasev);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("Error al agregar clase");

            }
        }
    }
}
