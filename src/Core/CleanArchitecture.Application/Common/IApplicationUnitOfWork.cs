using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Common;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    public Task<Result> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public interface IApplicationUnitOfWork : IUnitOfWork
{
    public DbSet<User> Users { get; }
}
