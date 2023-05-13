using EntregaSegura.Domain.Entities;
using EntregaSegura.Domain.Interfaces.Repositories;
using EntregaSegura.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EntregaSegura.Infrastructure.Repositories;

public class TransportadoraRepository : Repository<Transportadora>, ITransportadoraRepository
{
    public TransportadoraRepository(EntregaSeguraContext context) : base(context) { }

    public async Task<Transportadora> ObterTransportadoraComEntregasAsync(Guid transportadoraId)
    {
        var transportadora = await _context.Transportadoras
            .AsNoTracking()
            .Include(t => t.Entregas)
            .FirstOrDefaultAsync(t => t.Id == transportadoraId);

        return transportadora;
    }
    
    public async Task<Transportadora> ObterPorNomeAsync(string nome)
    {
        var transportadora = await _context.Transportadoras
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Nome == nome);

        return transportadora;
    }    
}