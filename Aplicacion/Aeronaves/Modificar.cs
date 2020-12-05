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

namespace Aplicacion.Aeronaves
{
    public class Modificar
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
                    //throw new Exception("La aeronave no existe");
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { nave = "La aeronave no existe" });
                }

                nave.modelo = request.Modelo ?? nave.modelo;


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
