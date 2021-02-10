using GraphQL.Types;

namespace Landlord.API.Types.InputTypes
{
    public class PropertyInputType : InputObjectGraphType<SRC.Models.Property>
    {
        public PropertyInputType()
        {
            Name = "PropertyInput";
            Field(x => x.Id);
            Field(x => x.ObjectNumber);
            Field(x => x.Street);
            Field(x => x.City);
            Field(x => x.PostalCode);
            Field(x => x.Country);
        }
    }
}
