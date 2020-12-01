using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.PrecioButacas
{
    public class Consulta
    {
        public class ListaPrecioB : IRequest<List<Dominio.precioButaca>> { }

        public class Manejador : IRequestHandler<ListaPrecioB, List<Dominio.precioButaca>>
        {
            private readonly AirlaneContext _context;

            public Manejador(AirlaneContext context)
            {
                _context = context;
            }
            public async Task<List<Dominio.precioButaca>> Handle(ListaPrecioB request, CancellationToken cancellationToken)
            {
                var preciobutacas = await _context.precioButaca.ToListAsync();
                return preciobutacas;
            }
        }
    }
}
