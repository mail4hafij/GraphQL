using System.Collections.Generic;
using Landlord.SRC.Models;

namespace Landlord.SRC.Repositories.Contracts
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
        Property GetById(int id);
        Property Add(Property property);
    }
}
