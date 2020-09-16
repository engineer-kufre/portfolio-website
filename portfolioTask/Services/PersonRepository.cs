using portfolioTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolioTask.Services
{
    //PersonRepository implements the IPersonRepository class

    public class PersonRepository : IPersonRepository
    {
        //list of all persons in the data repository
        public List<Person> allPersons;

        //PersonRepository constructor
        public PersonRepository()
        {
            allPersons = new List<Person>
            {
                new Person{PersonId = 1,
                                  FirstName = "Kufreabasi",
                                  LastName = "Ita",
                                  Logo = "engineer-kufre",
                                  proficientPrograms = new List<ProgrammingLanguage>
                                  {
                                      new ProgrammingLanguage { pLanguageId = 1, pLanguageName = "C#"},
                                      new ProgrammingLanguage { pLanguageId = 2, pLanguageName = "Python"},
                                      new ProgrammingLanguage { pLanguageId = 3, pLanguageName = "JavaScript"}
                                  },
                                  education = new List<Education>
                                  {
                                      new Education{educationId = 1, schoolName = "Decagon", obtained = "Software Engineering Intern", startDate = "June 2020", endDate = "Present"},
                                      new Education{educationId = 2, schoolName = "HNG", obtained = "Graduate II (Start.ng Internship)", endDate = "May 2020"},
                                      new Education{educationId = 3, schoolName = "Olabisi Onabanjo University", obtained = "Bachelor of Science in Agricultural Engineering", startDate = "2004", endDate = "2010"},
                                  }
                },
                new Person{PersonId = 2,
                                  FirstName = "Nonso",
                                  LastName = "Amadi",
                                  Logo = "i-nonso",
                                  proficientPrograms = new List<ProgrammingLanguage>
                                  {
                                      new ProgrammingLanguage { pLanguageId = 4, pLanguageName = "PHP"},
                                      new ProgrammingLanguage { pLanguageId = 2, pLanguageName = "Python"},
                                      new ProgrammingLanguage { pLanguageId = 5, pLanguageName = "SQL"}
                                  },
                                  education = new List<Education>
                                  {
                                      new Education{educationId = 1, schoolName = "Decagon", obtained = "Software Engineering Intern", startDate = "June 2020", endDate = "Present"},
                                      new Education{educationId = 6, schoolName = "Bells University, Ota", obtained = "Bachelor of Science in Computer Science", startDate = "2010", endDate = "2015"},
                                  }
                }
            };
        }

        //method to get Person with the inputted id
        public Person GetPerson(int id)
        {
            return allPersons.FirstOrDefault(p => p.PersonId == id);
        }
    }
}
