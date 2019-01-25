using System.ComponentModel.DataAnnotations;

namespace ReactAbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}