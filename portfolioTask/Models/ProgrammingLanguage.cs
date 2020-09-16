using System.ComponentModel.DataAnnotations;

namespace portfolioTask.Models
{
    public class ProgrammingLanguage
    {
        //preferred programming language model

        [Key]
        public int pLanguageId { get; set; }
        [Required]
        public string pLanguageName { get; set; }
    }
}