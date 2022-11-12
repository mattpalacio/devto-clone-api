namespace DevtoClone.Api.DTOs.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public DateTime JoinedDate { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
