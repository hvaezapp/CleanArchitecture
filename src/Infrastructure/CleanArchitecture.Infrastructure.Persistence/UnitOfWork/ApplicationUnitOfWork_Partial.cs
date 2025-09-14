using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence.UnitOfWork;

public partial class ApplicationUnitOfWork
{
    public DbSet<User> Users => _context.Set<User>();
}