using Domain;
using Infrastructures.Interfaces;

namespace Infrastructures.Repositories;

public class StudentRepository(AppDbContext dbContext) : Repository<Student>(dbContext), IStudentInterface
{
}
