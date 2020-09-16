using portfolioTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolioTask.Services
{
    public interface IPersonRepository
    {
        //PersonRepository implements the IPersonRepository class

        public Person GetPerson(int id);
    }
}
