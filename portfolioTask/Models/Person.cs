using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace portfolioTask.Models
{
    public class Person
    {
        //person object model

        [Key]
        public int PersonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Logo { get; set; }
        public List<ProgrammingLanguage> proficientPrograms { get; set; }
        public List<Education> education { get; set; }

    }
}
