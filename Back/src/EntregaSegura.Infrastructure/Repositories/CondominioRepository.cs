using EntregaSegura.Domain.Entities;
using EntregaSegura.Domain.Interfaces.Repositories;
using EntregaSegura.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EntregaSegura.Infrastructure.Repositories;

public class CondominioRepository : Repository<Condominio>, ICondominioRepository
{
    public CondominioRepository(EntregaSeguraContext context) : base(context) { }

    public async Task<Condominio> ObterCondominioComFuncionariosAsync(Guid condominioId)
    {
        var condominio = await _context.Condominios
            .AsNoTracking()
            .Include(c => c.Funcionarios)
            .FirstOrDefaultAsync(c => c.Id == condominioId);

        return condominio;
    }

    public async Task<Condominio> ObterCondominioComUnidadesAsync(Guid condominioId)
    {
        var condominio = await _context.Condominios
            .AsNoTracking()
            .Include(c => c.Unidades)
            .FirstOrDefaultAsync(c => c.Id == condominioId);

        return condominio;
    }

    public async Task<Condominio> ObterPorNomeAsync(string nome)
    {
        var condominio = await _context.Condominios
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Nome == nome);

        return condominio;
    }

    public async Task<Condominio> ObterCondominioComUnidadesEFuncionariosAsync(Guid condominioId)
    {
        var condominio = await _context.Condominios
            .AsNoTracking()
            .Include(c => c.Unidades)
            .Include(c => c.Funcionarios)
            .FirstOrDefaultAsync(c => c.Id == condominioId);

        return condominio;
    }
}