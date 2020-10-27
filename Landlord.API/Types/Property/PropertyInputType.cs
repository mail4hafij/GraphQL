using GraphQL.Types;

namespace Landlord.API.Types.Property
{
    public class PropertyInputType : InputObjectGraphType
    {
        public PropertyInputType()
        {
            Name = "PropertyInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("city");
            Field<StringGraphType>("family");
            Field<StringGraphType>("street");
            Field<IntGraphType>("value");
        }
    }
}
