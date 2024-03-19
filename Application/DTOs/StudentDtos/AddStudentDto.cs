using Domain;

namespace Application.DTOs.StudentDtos;

public class AddStudentDto
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;

    public static implicit operator Student(AddStudentDto dto)
    {
        return new Student()
        {
            FullName = dto.FullName,
            Email = dto.Email,
            AvatarUrl = dto.AvatarUrl,
        };
    }
}
