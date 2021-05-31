using System.Collections.Generic;
using System.Linq;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccessSimulation
{
    public class DataAccess : IDataAccess
    {
        private List<Person> People = new List<Person>();

        public DataAccess()
        {
            People.Add(new Person { Id = 1, Name = "Parsa", LastName = "Mehdipour" });
            People.Add(new Person { Id = 2, Name = "Mark", LastName = "Dion" });
        }

        public List<Person> Get()
        {
            return People;
        }

        public Person Insert(Person person)
        {
            var p = new Person()
            {
                Name = person.Name,
                LastName = person.LastName
            };

            p.Id = People.Max(x => x.Id) + 1;

            People.Add(p);

            return p;
        }
    }
}
