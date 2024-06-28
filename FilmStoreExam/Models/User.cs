using Microsoft.AspNetCore.Identity;

namespace FilmStoreExam.Models
{
    public class User:IdentityUser
    {
        public string? Name { get; set; }
        public DateOnly? BirthDate { get; set; }
    }
}
