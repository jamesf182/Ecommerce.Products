using Ecommerce.Products.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace Ecommerce.Products.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly EcommerceProductsDbContext _dbContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork(EcommerceProductsDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                await _transaction.CommitAsync();
            }
            catch
            {
                await RollbackAsync();
                throw; // Re-throw the exception to propagate it
            }
        }

        public async Task RollbackAsync()
        {
            await _transaction.RollbackAsync();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _dbContext.Dispose();
        }
    }
}
