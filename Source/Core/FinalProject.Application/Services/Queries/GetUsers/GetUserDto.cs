namespace FinalProject.Application.Services.Queries.GetUsers
{
    public class GetUserDto
    {
        public long Id { get; set; }
        public required string Fullname { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
    




}