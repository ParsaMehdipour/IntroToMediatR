using System.Collections.Generic;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    public class GetPersonListQuery :IRequest<List<Person>>
    {

    }
}
