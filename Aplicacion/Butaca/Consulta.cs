using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Butaca
{
    public class Consulta
    {
        public class ListaButaca : IRequest<List<Dominio.Butaca>> { }

        public class Manejador : IRequestHandler<ListaButaca, List<Dominio.Butaca>>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<List<Dominio.Butaca>> Handle(ListaButaca request, CancellationToken cancellationToken)
            {
                var butacas = await _context.Butaca.ToListAsync();
                return butacas;
            }
        }
    }
}
