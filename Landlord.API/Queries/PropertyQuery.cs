using GraphQL.Types;
using Landlord.API.Types;
using Landlord.SRC.Repositories.Contracts;

namespace Landlord.API.Queries
{
    public class PropertyQuery : ObjectGraphType
    {
        public PropertyQuery(IPropertyRepository propertyRepository, IPaymentRepository paymentRepository)
        {
            Field<ListGraphType<PropertyType>>(
                "properties",
                resolve: context => propertyRepository.GetAll());

            Field<PropertyType>(
                "property",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => propertyRepository.GetById(context.GetArgument<int>("id")));
        }
    }
}