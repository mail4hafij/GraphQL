using GraphQL.Types;

namespace Landlord.API.Types
{
    public class PaymentType : ObjectGraphType<SRC.Models.Payment>
    {
        public PaymentType()
        {
            Field(x => x.Id);
            Field(x => x.Value);
            Field(x => x.DateCreated);
            Field(x => x.DateOverdue);
            Field(x => x.Paid);
        }
    }
}
