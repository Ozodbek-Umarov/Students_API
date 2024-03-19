using Application.DTOs.StudentDtos;

namespace Application.Interfaces;

public interface IStudentService
{
    Task<List<StudentDto>> GetAllAsync();
    Task<StudentDto> GetByIdAsync(int id);
    Task AddAsync(AddStudentDto dto);
    Task UpdateAsync(StudentDto dto);
    Task DeleteAsync(int id);
}
