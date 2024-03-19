using Infrastructures.Interfaces;

namespace Infrastructures.Repositories;

public class UnitOfWork(AppDbContext dbContext)
    : IUnitOfWork
{
    private readonly AppDbContext dbContext = dbContext;

    public IStudentInterface studentInterface => new StudentRepository(dbContext);
}
