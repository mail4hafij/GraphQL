using GraphQL.Types;
using Landlord.SRC.Repositories.Contracts;

namespace Landlord.API.Types
{
    public class PropertyType : ObjectGraphType<SRC.Models.Property>
    {
        public PropertyType(IPaymentRepository paymentRepository)
        {
            Field(x => x.Id);
            Field(x => x.ObjectNumber);
            Field(x => x.Street);
            Field(x => x.City);
            Field(x => x.PostalCode);
            Field(x => x.Country);

            Field<ListGraphType<PaymentType>>("payments",
                resolve: context =>
                {
                    return paymentRepository.GetAllByProperty(context.Source.Id);
                });
        }
    }
}