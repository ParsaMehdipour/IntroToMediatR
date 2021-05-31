using System.Collections.Generic;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccessSimulation
{
    public interface IDataAccess
    {
        List<Person> Get();
        Person Insert(Person person);
    }
}