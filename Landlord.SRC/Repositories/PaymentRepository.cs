using System;
using System.Collections.Generic;
using Landlord.SRC.Models;
using Landlord.SRC.Repositories.Contracts;

namespace Landlord.SRC.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        
        public PaymentRepository()
        {
            
        }

        public IEnumerable<Payment> GetAllByProperty(int propertyId)
        {
            return new List<Payment>
            {
                new Payment
                {
                    Id = 1,
                    PropertyId = 1,
                    DateCreated = DateTime.Now,
                    DateOverdue = DateTime.Now.AddDays(3),
                    Paid = false,
                    Property = new Property
                    {
                        Id = 1,
                        ObjectNumber = "1101",
                        Street = "Stenhagen",
                        City = "Uppsala",
                        Country = "Sweden",
                        PostalCode = "75267"
                    },
                    Value = 4000
                },
                new Payment
                {
                    Id = 2,
                    PropertyId = 1,
                    DateCreated = DateTime.Now,
                    DateOverdue = DateTime.Now.AddDays(3),
                    Paid = true,
                    Property = new Property
                    {
                        Id = 1,
                        ObjectNumber = "1101",
                        Street = "Stenhagen",
                        City = "Uppsala",
                        Country = "Sweden",
                        PostalCode = "75267"
                    },
                    Value = 6000
                }
            };
        }
    }
}
