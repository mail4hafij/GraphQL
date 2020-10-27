using System.Collections.Generic;
using Landlord.SRC.Models;

namespace Landlord.SRC.Repositories.Contracts
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetAllForProperty(int propertyId);
        IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount);

    }
}
