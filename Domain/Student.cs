namespace Domain;

public class Student : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string AvatarUrl { get; set; }
}
