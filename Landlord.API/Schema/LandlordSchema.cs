using GraphQL;
using Landlord.API.Mutations;
using Landlord.API.Queries;

namespace Landlord.API.Schema
{
    public class LandlordSchema : GraphQL.Types.Schema
    {
        public LandlordSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PropertyQuery>();
            Mutation = resolver.Resolve<PropertyMutation>();
        }
    }
}
