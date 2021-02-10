using System.Collections.Generic;

namespace Landlord.SRC.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string ObjectNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
