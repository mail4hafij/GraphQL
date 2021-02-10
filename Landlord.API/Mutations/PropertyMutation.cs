using GraphQL.Types;
using Landlord.API.Types;
using Landlord.API.Types.Property.InputTypes;
using Landlord.SRC.Models;
using Landlord.SRC.Repositories.Contracts;

namespace Landlord.API.Mutations
{
    public class PropertyMutation : ObjectGraphType
    {
        public PropertyMutation(IPropertyRepository propertyRepository)
        {
            Name = "AddPropertyMutation";

            Field<PropertyType>(
                "addProperty",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PropertyInputType>> {Name = "property"}),
                resolve: context =>
                {
                    var property = context.GetArgument<Property>("property");
                    return propertyRepository.Add(property);
                });
        }
    }
}
