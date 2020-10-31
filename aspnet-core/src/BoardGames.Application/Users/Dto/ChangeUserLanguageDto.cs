using System.ComponentModel.DataAnnotations;

namespace BoardGames.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}