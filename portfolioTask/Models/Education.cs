using System.ComponentModel.DataAnnotations;

namespace portfolioTask.Models
{
    public class Education
    {
        //education object model

        [Key]
        public int educationId { get; set; }
        [Required]
        public string schoolName { get; set; }
        public string obtained { get; set; }
        public string startDate { get; set; }
        [Required]
        public string endDate { get; set; }
    }
}