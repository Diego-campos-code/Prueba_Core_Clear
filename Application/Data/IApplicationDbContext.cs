using Microsoft.EntityFrameworkCore;
using Domain.Customers;

namespace Application.Data;

public interface IApplicationDdContext
{
        DbSet<Customer> Customers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}