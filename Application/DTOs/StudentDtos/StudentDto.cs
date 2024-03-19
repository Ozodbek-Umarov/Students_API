using Domain;

namespace Application.DTOs.StudentDtos;

public class StudentDto : AddStudentDto
{
    public int Id { get; set; }
    public static implicit operator StudentDto(Student student)
        => new()
        {
            Id = student.Id,
            FullName = student.FullName,
            Email = student.Email,
            AvatarUrl = student.AvatarUrl,
        };
}
