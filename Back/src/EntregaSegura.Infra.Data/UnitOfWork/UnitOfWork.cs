using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;
using EntregaSegura.Infra.Data.Contexts;

namespace EntregaSegura.Infra.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly EntregaSeguraContext _context;
    private readonly ILogger<UnitOfWork> _logger;

    public UnitOfWork(EntregaSeguraContext context, ILogger<UnitOfWork> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<int> CommitAsync()
    {
        using (var transaction = await _context.Database.BeginTransactionAsync())
        {
            try
            {
                var linhasAfetadas = await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();

                if (ex is DbUpdateException dbEx && dbEx.InnerException is SqlException sqlEx && (sqlEx.Number == 547 || sqlEx.Number == 2627))
                {
                    _logger.LogError(ex, $"Ocorreu um erro de restrição de chave estrangeira ao salvar as alterações no banco de dados: {ex.Message}");
                    throw new Exception("Esta entidade não pode ser excluída, pois está em uso.");
                }
                else
                {
                    _logger.LogError(ex, $"Ocorreu um erro ao salvar as alterações no banco de dados: {ex.Message}");
                    return 0;
                }
            }
        }
    }

    public EntregaSeguraContext Context => _context;

    public void Dispose()
    {
        _context.Dispose();
    }
}
