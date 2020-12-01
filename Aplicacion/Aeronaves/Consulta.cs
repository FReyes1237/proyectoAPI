using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Aeronaves
{
    public class Consulta
    {
        public class ListaAeronaves : IRequest<List<Aeronave>> { }

        public class Manejador : IRequestHandler<ListaAeronaves, List<Aeronave>>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<List<Aeronave>> Handle(ListaAeronaves request, CancellationToken cancellationToken)
            {
                var aeronaves = await _context.Aeronave.ToListAsync();
                return aeronaves;
            }
        }
    }
}
//Operation save watson